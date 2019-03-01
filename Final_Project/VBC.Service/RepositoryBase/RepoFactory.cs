using System;
using System.Collections.Generic;
using System.Text;

namespace VBC.Service.RepositoryBase
{
    public static class RepoFactory<TEntity> where TEntity : class
    {
        public static IBaseRepository<TEntity> CreateRepo(IUnitOfWork uow)
        {
            return new BaseRepository<TEntity>(uow.DbContext);
        }
    }
}
