using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBl_.Models
{
    public class Check
    {
        public int CheckID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }//связь между двумя сущностями,один ко многим.Т.е по нашему чеку мы можем получить покупателя

        public int SellerID { get; set; }
        public virtual Seller Seller { get; set; }

        public DateTime Created { get; set; }

        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"#{CheckID} from {Created.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
