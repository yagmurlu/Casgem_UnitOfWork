using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class
    {
        void Insert(T entity);
        void Delete(T entity);
        void Update(T entity);
        List<T> GetList();
        T GetById(int id);
        void MultiUpdate(List<T> t);
    }
}
