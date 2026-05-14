using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Library_IS.Lib
{
    internal class Repository
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public TEntity InsertEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                _dbContext.Set<TEntity>().Add(entity);
                _dbContext.SaveChanges();
                return entity;
            }
            catch { throw; }
        }
        public List<TEntity> GetEntities<TEntity>() where TEntity : class
        {
            try
            {
                return _dbContext.Set<TEntity>().AsNoTracking().ToList();
            }
            catch { throw; }
        }
        public bool DeleteEntityById<TEntity>(object id) where TEntity : class
        {
            try
            {
                TEntity entity = GetEntityById<TEntity>(id);
                if (entity == null)
                { return false; }
                return DeleteEntity<TEntity>(entity);
            }
            catch { throw; }
        }
        public bool DeleteEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                var entry = _dbContext.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    return false;
                }
                _dbContext.Set<TEntity>().Remove(entity);
                _dbContext.SaveChanges();
                return true;
            }
            catch { throw; }
        }
        public TEntity GetEntityById<TEntity>(object id) where TEntity : class
        {
            try
            {
                return _dbContext.Set<TEntity>().Find(id);
            }
            catch { throw; }
        }
        public bool UpdateEntity<TEntity>(TEntity entity) where TEntity : class
        {
            try
            {
                var entry = _dbContext.Entry(entity);
                if (entry.State == EntityState.Detached)
                {
                    return false;
                }
                entry.State = EntityState.Modified;
                _dbContext.SaveChanges();
                return true;
            }
            catch { throw; }
        }
        public List<TEntity> GetEntitiesByFilter<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            try
            {
                DbSet<TEntity> dbSet = _dbContext.Set<TEntity>();
                return dbSet.Where(filter).AsNoTracking().ToList();
            }
            catch { throw; }
        }
        public TEntity GetEntityByFilter<TEntity>(Expression<Func<TEntity, bool>> filter) where TEntity : class
        {
            try
            {
                IQueryable<TEntity> query = _dbContext.Set<TEntity>();
                return query.FirstOrDefault(filter);
            }
            catch { throw; }
        }
    }
}
