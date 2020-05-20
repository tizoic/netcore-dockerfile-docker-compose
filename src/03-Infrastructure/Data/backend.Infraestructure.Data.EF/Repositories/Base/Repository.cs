using System;
using System.Collections.Generic;
using backend.Domain.Repositories.Base;
using backend.Infraestructure.Data.EF.Context;
using Microsoft.EntityFrameworkCore;

namespace backend.Infraestructure.Data.EF.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly PersonContext _personContext;
        protected readonly DbSet<T> dbSet;

        public Repository(PersonContext personContext)
        {
            _personContext = personContext;
            dbSet = _personContext.Set<T>();
        }

        public T Add(T entity)
        {
            dbSet.Add(entity);
            Save();
            return entity;
        }

        public void Delete(Guid id)
        {
            var entity = dbSet.Find(id);
            dbSet.Remove(entity);
            Save();
        }

        private void Save()
        {
            _personContext.SaveChanges();
        }

        public T Update(T entity)
        {
            dbSet.Update(entity);
            Save();

            return entity;
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking();
        }
    }
}

