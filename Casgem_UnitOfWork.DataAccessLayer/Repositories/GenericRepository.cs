using Casgem_UnitOfWork.DataAccessLayer.Abstract;
using Casgem_UnitOfWork.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem_UnitOfWork.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly Context _context;

        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T entity)
        {
             _context.Remove(entity);
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
           _context.Add(entity);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);
        }

        public void Update(T entity)
        {
            _context.Update(entity);
        }
    }
}
