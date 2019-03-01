using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Doitsu.Service
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected DbContext _dbContext;
        protected DbSet<T> _dbSet;
        public BaseRepository()
        {

        }
        public BaseRepository(DbContext dbContext) : this()
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public virtual T Create(T entity)
        {
            _dbSet.Add(entity);
            return entity;
        }

        public virtual async Task<T> CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public virtual T Find<Tkey>(Tkey id)
        {
            return _dbSet.Find(id);
        }
        public virtual async Task<T> FindAsync<Tkey>(Tkey id)
        {
            return await _dbSet.FindAsync(id);
        }
        public virtual T FirstOrDefault(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public T FirstOrDefault()
        {
            return _dbSet.FirstOrDefault();
        }

        public virtual T FirstOrDefaultActive(Expression<Func<T, bool>> predicate)
        {
            if (typeof(IActivable).IsAssignableFrom(typeof(T)))
            {
                var sourceQuerable = _dbSet.Where<T>(predicate);
                Expression<Func<T, bool>> checkActiveExpress = (T t) => ((IActivable)t).Active;
                var cleanCheckActiveExpress = (Expression<Func<T, bool>>)RemoveCastsVisitor.Visit(checkActiveExpress);
                return sourceQuerable.FirstOrDefault(cleanCheckActiveExpress);

            }
            return this.FirstOrDefault(predicate);
        }

        public virtual Task<T> FirstOrDefaultActiveAsync(Expression<Func<T, bool>> predicate)
        {
            if (typeof(IActivable).IsAssignableFrom(typeof(T)))
            {
                var sourceQuerable = _dbSet.Where<T>(predicate);
                Expression<Func<T, bool>> checkActiveExpress = (T t) => ((IActivable)t).Active;
                var cleanCheckActiveExpress = (Expression<Func<T, bool>>)RemoveCastsVisitor.Visit(checkActiveExpress);
                return sourceQuerable.FirstOrDefaultAsync(cleanCheckActiveExpress);

            }
            return this.FirstOrDefaultAsync(predicate);
        }

        public virtual Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.FirstOrDefaultAsync(predicate);

        }

        public async Task<T> FirstOrDefaultAsync()
        {
            return await _dbSet.FirstOrDefaultAsync();
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public virtual IQueryable<T> GetActive(Expression<Func<T, bool>> predicate)
        {
            if (typeof(IActivable).IsAssignableFrom(typeof(T)))
            {
                var sourceQuerable = _dbSet.Where<T>(predicate);
                Expression<Func<T, bool>> checkActiveExpress = (T t) => ((IActivable)t).Active;
                var cleanCheckActiveExpress = (Expression<Func<T, bool>>)RemoveCastsVisitor.Visit(checkActiveExpress);
                return sourceQuerable.Where(cleanCheckActiveExpress);

            }
            return this.Get(predicate);
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public virtual IQueryable<T> GetAllActive()
        {
            if (typeof(IActivable).IsAssignableFrom(typeof(T)))
            {
                var sourceQuerable = _dbSet.AsQueryable();
                Expression<Func<T, bool>> checkActiveExpress = (T t) => ((IActivable)t).Active;
                var cleanCheckActiveExpress = (Expression<Func<T, bool>>)RemoveCastsVisitor.Visit(checkActiveExpress);
                return sourceQuerable.Where(cleanCheckActiveExpress);

            }
            return this.GetAll();
        }

        public int SaveChange()
        {
            return _dbContext.SaveChanges();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public virtual T Update(T entity)
        {
            _dbSet.Attach(entity);
            _dbSet.Update(entity);
            return entity;
        }

        public virtual Task<T> UpdateAsync(T entity)
        {
            throw new NotImplementedException("Cannot implement this method, please dont use it!");
        }


    }
}
