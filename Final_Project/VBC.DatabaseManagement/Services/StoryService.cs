using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VBC.DatabaseManagement.Models.Entities;
using VBC.DatabaseManagement.ViewModels;
using VBC.Service;

namespace VBC.DatabaseManagement.Services
{
    public interface IStoryService : IBaseService<Story, StoryViewModel>
    {
        Task<ICollection<StoryViewModel>> GetStoryNameLike(string storyName);

    }
    class StoryService : BaseService<Story, StoryViewModel>, IStoryService
    {
        public StoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

        public async Task<ICollection<StoryViewModel>> GetStoryNameLike(string storyName)
        {
            try
            {
                var list = new List<StoryViewModel>();

                var listItems = this.selfDbSet.AsNoTracking().FromSql("SELECT * FROM Story WHERE Name LIKE N'%" + storyName + "%' order by Id DESC").ToList();
                foreach (var item in listItems)
                {
                    //apply automapper
                    var recipeViewModel = this.EntityToVM(item);

                    list.Add(recipeViewModel);

                }
                return list;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
