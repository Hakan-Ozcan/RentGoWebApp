using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        DataBaseContext c = new DataBaseContext();
        DbSet<T> _object;
        public GenericRepository()
        {
            _object = c.Set<T>();
        }
        public void Delete(T p)
        {
            var deletedentity = c.Entry(p);
            deletedentity.State = EntityState.Deleted;
            //_object.Remove(p);
            c.SaveChanges();

        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T p)
        {
            var addedEntity = c.Entry(p);
            addedEntity.State = EntityState.Added;
            // _object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T p)
        {
            var updatedentity = c.Entry(p);
            updatedentity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
