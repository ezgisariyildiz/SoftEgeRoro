using EgeRoroData.Abstract;
using EgeRoroData.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoroData.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public void Delete(T entity)
        {
            using var db = new Context();
            db.Remove(entity);
            db.SaveChanges();
        }

        public T GetById(int id)
        {
            using var db = new Context();
            return db.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var db = new Context();
            return db.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using var db = new Context();
            db.Add(entity);
            db.SaveChanges();
        }

        public void Update(T entity)
        {
            using var db = new Context();
            db.Update(entity);
            db.SaveChanges();
        }
    }
}
