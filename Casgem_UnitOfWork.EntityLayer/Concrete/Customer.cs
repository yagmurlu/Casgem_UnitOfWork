using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public decimal CustomerBalance { get; set; }
    }
}
