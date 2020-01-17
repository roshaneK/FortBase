using FortBase.Repository.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace FortBase.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected FortBaseDbContext FortBaseDbContext { get; set; }

        public RepositoryBase(FortBaseDbContext FortBaseDbContext)
        {
            this.FortBaseDbContext = FortBaseDbContext;
        }

        public IQueryable<T> FindAll()
        {
            return FortBaseDbContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return FortBaseDbContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            FortBaseDbContext.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            FortBaseDbContext.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            FortBaseDbContext.Set<T>().Remove(entity);
        }

        public void Save()
        {
            FortBaseDbContext.SaveChanges();
        }
    }
}
