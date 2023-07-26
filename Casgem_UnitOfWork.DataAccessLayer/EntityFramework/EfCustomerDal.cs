using Casgem_UnitOfWork.DataAccessLayer.Abstract;
using Casgem_UnitOfWork.DataAccessLayer.Concrete;
using Casgem_UnitOfWork.DataAccessLayer.Repositories;
using Casgem_UnitOfWork.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal:GenericRepository<Customer>,ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {

        }
    }
}
