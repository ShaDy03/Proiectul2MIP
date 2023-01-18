﻿using DataAccess.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;

        private DbSet<T> DbSet;

        public Repository(DbContext context)
        {
            Context = context;
            DbSet = context.Set<T>();
        }

        public Task Add(T entity)
        {
            DbSet.Add(entity);
            Context.SaveChanges();
            return Task.CompletedTask;
        }

        public Task<bool> Exists(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = DbSet;
            return Task.FromResult(query.Any(filter));
        }

        public Task<IEnumerable<T>> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = DbSet;
            IEnumerable<T> response = Enumerable.Empty<T>();

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (orderBy != null)
            {
                response = orderBy(query).ToList();
                return Task.FromResult(response);
            }
            response = query.ToList();
            return Task.FromResult(response);
        }

        public Task<T> GetById(int id) => Task.FromResult(DbSet.Find(id));

        public Task<T> GetFirstOrDefault(Expression<Func<T, bool>> filter = null)
        {
            IQueryable<T> query = DbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            return Task.FromResult(query.FirstOrDefault());
        }
    }
}
