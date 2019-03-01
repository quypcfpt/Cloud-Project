using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace VBC.Service
{
    public class UnitOfWork: IUnitOfWork,IDisposable
    {
        private DbContext _dbContext;
        private bool _disposed = false;
        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        #region Unit Of Work features
       
        public DbContext GetDbContext() {
            return _dbContext;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                    this._disposed = true;
                }
            }
          
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public async Task Commit()
        {
           await _dbContext.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> GetDbTransaction()
        {
            return await _dbContext.Database.BeginTransactionAsync();
        }
        #endregion

    }
}
