using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Threading.Tasks;
using System.Transactions;

namespace VBC.Service
{
    public interface IUnitOfWork: IDisposable
    {
        #region Unit Of Work features
        DbContext GetDbContext();
        Task Commit();
        void Dispose();
        Task<IDbContextTransaction> GetDbTransaction();
        #endregion
    }
}