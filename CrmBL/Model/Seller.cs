using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBL.Model
{
    class Seller
    {
        public int SellerID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Check> Checks { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
