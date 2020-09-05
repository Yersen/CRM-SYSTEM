using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrmBl_.Models;

namespace CrmUI_
{
    public partial class Main : Form
    {
        Context db;
        Cart cart;
        Customer customer;
        CashDesk cashDesk;

        public Main()
        {
            InitializeComponent();
            db = new Context();
            cart = new Cart(customer);
            cashDesk = new CashDesk(1, db.Sellers.FirstOrDefault(),db)
            {
                IsModel = false
            };
        }

        private void сущностиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }



        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers , db);
            catalogSeller.Show();
        }

        private void CustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkCustomer = new Catalog<Check>(db.Checks, db);
            checkCustomer.Show();
        }

        private void SellerAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void CustomerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void productAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                listBox1.Invoke((Action)delegate
                {
                    listBox1.Items.AddRange(db.Products.ToArray());
                    UpdateLists();
                });
            });
        }

        private void modelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.Show();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is Product product)
            {
                cart.Add(product);
                listBox2.Items.Add(product);
                UpdateLists();
            }
        }
        private void UpdateLists()
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(cart.GetAll().ToArray());
            label1.Text = "Итого:" + cart.Price;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            var form =new Login();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK)
            {
                var tempCustomer = db.Customers.FirstOrDefault(c => c.Name.Equals(form.Customer.Name));
                if(tempCustomer != null)
                {
                    customer = tempCustomer;
                }
                else
                {
                    db.Customers.Add(form.Customer);
                    db.SaveChanges();
                    customer = form.Customer;
                }
                cart.Customer = customer;
            }
            linkLabel1.Text = $"Здравствуй , {customer.Name}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Сделать проверку на забивку корзины Main.cs сделать удаление в чеках
            if (customer != null && cart.Price != null)
            {
                cashDesk.Enqueue(cart);
                var price = cashDesk.Dequeue();
                listBox2.Items.Clear();
                cart = new Cart(customer);

                MessageBox.Show($"Поздравляю с оформлением покупки! Сумма покупки-{price}", "Покупка выполнена",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Авторизуйтесь в приложении", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
