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
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;
        private readonly IUowDal _uowDal;

        public CustomerManager(ICustomerDal customerDal, IUowDal uowDal)
        {
            _customerDal = customerDal;
            _uowDal = uowDal;
        }

        public List<Customer> GetList()
        {
            return _customerDal.GetList();
            
        }

        public void TDelete(Customer entity)
        {
            _customerDal.Delete(entity);
            _uowDal.Save();
        }

        public Customer TGetById(int id)
        {
            return _customerDal.GetById(id);
        }

        public void TInsert(Customer entity)
        {
            _customerDal.Insert(entity);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(Customer entity)
        {
            _customerDal.Update(entity);
            _uowDal.Save();
        }
    }
}
