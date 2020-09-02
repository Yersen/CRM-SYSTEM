using System;
using System.Collections.Generic;
using System.Text;

namespace CrmBL.Model
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Check> Checks { get; set;}//связь между двумя сущностями,один ко многим.Т.е по нашему чеку мы можем получить покупателя

        public override string ToString()
        {
            return Name;
        }
    }
}
