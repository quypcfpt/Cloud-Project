using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VBC.DatabaseManagement.Models.Entities;
using VBC.DatabaseManagement.ViewModels;
using VBC.Service;

namespace VBC.DatabaseManagement.Services
{
    public interface IStoryCategoryService :IBaseService<StoryCategory, StoryCategoryViewModel>
    {

    }

     class StoryCategoryService: BaseService<StoryCategory, StoryCategoryViewModel>, IStoryCategoryService
    {
        public StoryCategoryService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
