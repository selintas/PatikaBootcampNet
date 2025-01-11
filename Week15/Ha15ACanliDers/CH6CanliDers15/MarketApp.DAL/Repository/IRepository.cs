using MarketApp.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.DAL.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Add(T entity);

        void Delete(T entity);

        void Update(T entity);

        T? GetById(int id);

        T? FirstOrDefault(Expression<Func<T, bool>> predicate);

        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> predicate);
    }
}
