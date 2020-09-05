using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBl_.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }


        public override string ToString()
        {
            return $"{Name} - {Price}";
        }

        public override int GetHashCode()
        {
            return ProductID;
        }
        public override bool Equals(object obj)
        {
            if (obj is Product product)
            {
                return ProductID.Equals(product.ProductID);
            }
            return false;
        }
    }
}
