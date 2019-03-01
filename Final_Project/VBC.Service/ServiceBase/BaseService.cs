using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VBC.Service
{
    public interface IActivable
    {
        bool Active { get; set; }
    }

    /// <summary>
    /// Class nay giong nhu abstract class 
    /// ho tro cho viec tao Service 1 cach nhanh nhat
    /// Nhan request vao View Model va xu ly Entity
    /// </summary>
    public class BaseService<TEntity, TViewModel> : IBaseService<TEntity, TViewModel>
        where TEntity : class, new()
        where TViewModel : class, new()
    {
        // O day minh phai implement 1 ham khac ngoai service co san, nen minh can phai dung unit of work va mapper va dbset
        // doi toan bo private thanh protected
        protected IUnitOfWork unitOfWork;
        protected IMapper mapper;
        protected DbSet<TEntity> selfDbSet;

        public BaseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.selfDbSet = unitOfWork.GetDbContext().Set<TEntity>();
        }

        #region Mapper
        protected TEntity ToEntity(TViewModel data)
        {
            var entity = new TEntity();
            var vm = mapper.Map<TViewModel, TEntity>(data, entity);
            return entity;
        }
        protected TViewModel ToViewModel(TEntity data)
        {
            var vm = new TViewModel();
            var entity = mapper.Map<TEntity, TViewModel>(data, vm);
            return vm;
        }

        protected GEntity ToEntity<GEntity, GViewModel>(GViewModel data)
            where GEntity : class, new()
        {
            var entity = new GEntity();
            var vm = mapper.Map<GViewModel, GEntity>(data, entity);
            return entity;
        }
        protected GViewModel ToViewModel<GEntity, GViewModel>(GEntity data)
          where GViewModel : class, new()
        {
            var viewModel = new GViewModel();
            var vm = mapper.Map<GEntity, GViewModel>(data, viewModel);
            return viewModel;
        }
        #endregion

        public async Task<TViewModel> CreateAsync(TViewModel data)
        {
            var entity = ToEntity(data);
            await selfDbSet.AddAsync(entity);
            await unitOfWork.Commit();
            var newViewModel = ToViewModel(entity);
            return newViewModel;
        }

        public async Task DeleteAsync<TKey>(TKey id)
        {
            var entity = await selfDbSet.FindAsync(id);
            selfDbSet.Remove(entity);
            await unitOfWork.Commit();
            var newVM = ToViewModel(entity);
        }

        public async Task<TViewModel> FirstOrDefaultAsync()
        {
            var entity = await selfDbSet.AsNoTracking().FirstOrDefaultAsync();
            var viewModel = ToViewModel(entity);
            return viewModel;
        }

        public async Task<TViewModel> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> predicate)
        {
            var entity = await selfDbSet.AsNoTracking().FirstOrDefaultAsync(predicate);
            var viewModel = ToViewModel(entity);
            return viewModel;
        }

        public IQueryable<TViewModel> Get()
        {
            var list = selfDbSet.AsNoTracking();
            var listVM = list.ProjectTo<TViewModel>(this.mapper.ConfigurationProvider);
            return listVM;
        }

        public IQueryable<TViewModel> Get(Expression<Func<TEntity, bool>> predicate)
        {
            var list = selfDbSet.AsNoTracking().Where(predicate);
            var listVM = list.ProjectTo<TViewModel>(this.mapper.ConfigurationProvider);
            return listVM;
        }

        public async Task<TViewModel> UpdateAsync(TViewModel data)
        {
            var entity = ToEntity(data);
            selfDbSet.Update(entity);
            await unitOfWork.Commit();
            var newViewModel = ToViewModel(entity);
            return newViewModel;
        }
    }
}
