using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VBC.DatabaseManagement.Models.Entities;
using VBC.DatabaseManagement.ViewModels;
using VBC.Service;

namespace VBC.DatabaseManagement.Services
{
    public interface IStoryService : IBaseService<Story, StoryViewModel>
    {

    }
    class StoryService : BaseService<Story, StoryViewModel>, IStoryService
    {
        public StoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }

    }
}
