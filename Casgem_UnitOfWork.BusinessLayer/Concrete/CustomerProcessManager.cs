using Casgem_UnitOfWork.BusinessLayer.Abstract;
using Casgem_UnitOfWork.DataAccessLayer.Abstract;
using Casgem_UnitOfWork.DataAccessLayer.UnitOfWork.Abstract;
using Casgem_UnitOfWork.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.BusinessLayer.Concrete
{
    public class CustomerProcessManager : ICustomerProcessService
    {
        private readonly ICustomerProcessDal _customerProcessDal;
        private readonly IUowDal _uowDal;

        public CustomerProcessManager(ICustomerProcessDal customerProcessDal, IUowDal uowDal)
        {
            _customerProcessDal = customerProcessDal;
            _uowDal = uowDal;
        }

        public List<CustomerProcess> GetList()
        {
            return _customerProcessDal.GetList();
        }

        public void TDelete(CustomerProcess entity)
        {
            _customerProcessDal.Delete(entity);
            _uowDal.Save();
        }

        public CustomerProcess TGetById(int id)
        {
            return _customerProcessDal.GetById(id);
        }

        public void TInsert(CustomerProcess entity)
        {
            _customerProcessDal.Insert(entity);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<CustomerProcess> t)
        {
            _customerProcessDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(CustomerProcess entity)
        {
            _customerProcessDal.Update(entity);
            _uowDal.Save();
        }
    }
}
