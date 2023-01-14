using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        IEnumerable<T> GetAll(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null
            );

        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null);

        T GetById(int id);

        bool Exists(Expression<Func<T, bool>> filter);
    }
}
