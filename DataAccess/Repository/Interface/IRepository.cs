using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        Task<IEnumerable<T>> GetAll(
                Expression<Func<T, bool>> filter = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null
            );

        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null);

        Task<T> GetById(int id);

        bool Exists(Expression<Func<T, bool>> filter);
    }
}
