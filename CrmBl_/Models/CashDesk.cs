using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrmBl_.Models
{
    public class CashDesk
    {
        Context db = new Context();

        public int Number { get; set; }
        public Seller Seller { get; set; }

        public Queue<Cart> Queue { get; set; }
        public int MaxQueueLenght { get; set; }
        public int ExitCustomer { get; set; }
        public bool IsModel { get; set; }//будет ли выполняться контекст в БД
        public int Count => Queue.Count;
        public event EventHandler<Check> checkClosed;
        public CashDesk(int number, Seller seller)

        {
            Number = number;
            Seller = seller;
            Queue = new Queue<Cart>();
            IsModel = true;
            MaxQueueLenght = 10;
        }
        public void Enqueue(Cart cart)//add people in Queue
        {
            if (Queue.Count < MaxQueueLenght)
            {
                Queue.Enqueue(cart);
            }
            else
            {
                ExitCustomer++;
            }
        }

        public decimal Dequeue()
        {
            decimal sum = 0;
            if (Queue.Count == 0)
            {
                return 0;
            }
            var cart = Queue.Dequeue();
            if (cart != null)
            {
                var check = new Check()
                {
                    SellerID = Seller.SellerID,
                    Seller = Seller,
                    CustomerID = cart.Customer.CustomerID,
                    Customer = cart.Customer,
                    Created = DateTime.Now
                };
                if (!IsModel)
                {
                    db.Checks.Add(check);
                    db.SaveChanges();
                }
                else
                {
                    check.CheckID = 0;
                }

                var sells = new List<Sell>();

                foreach (Product product in cart)
                {
                    if (product.Count > 0)
                    {
                        var sell = new Sell()
                        {
                            CheckID = check.CheckID,
                            Check = check,
                            ProductID = product.ProductID,
                            Product = product
                        };

                        sells.Add(sell);

                        if (!IsModel)
                        {
                            db.Sells.Add(sell);
                        }
                        product.Count--;
                        sum += product.Price;
                    }
                }

                check.Price = sum;

                if (!IsModel)
                {
                    db.SaveChanges();
                }
                checkClosed?.Invoke(this,check);//проверка на null
            }
            return sum;
        }

        public override string ToString()
        {
            return $"Касса №{Number}" ;
        }
    }
}
