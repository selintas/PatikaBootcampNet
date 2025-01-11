using MarketApp.DAL.Context;
using MarketApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.DAL.Repository
{
    public class EfRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _db;

        public EfRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public T Add(T entity)
        {
            _db.Add(entity);
            _db.SaveChanges();
            return entity;
        }

        public void Delete(T entity)
        {
            _db.Remove(entity);
            _db.SaveChanges();
        }

        public T? FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().FirstOrDefault(predicate);
        }

        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate).ToList();
        }

        public T? GetById(int id)
        {
            return _db.Find<T>(id);
        }

        public void Update(T entity)
        {
            _db.Update(entity);
            _db.SaveChanges();
        }
    }
}
