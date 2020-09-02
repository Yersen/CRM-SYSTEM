using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBl_.Models
{
    public class Sell
    {
        public int SellID { get; set; }
        public int CheckID { get; set; }
        public int ProductID { get; set; }
        public virtual Check Check { get; set; }
        public virtual Product Product { get; set; }
    }
}
