using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.EntityLayer.Concrete
{
    public class CustomerProcess
    {
        public int CustomerProcessID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public decimal Amount { get; set; }
    }
}
