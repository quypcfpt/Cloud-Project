using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VBC.DatabaseManagement.Models.Entities;
using VBC.DatabaseManagement.ViewModels;
using VBC.Service;

namespace VBC.DatabaseManagement.Services
{
    public interface IChapterService : IBaseService<Chapter, ChapterViewModel>
    {

    }

    class ChapterService : BaseService<Chapter, ChapterViewModel>, IChapterService
    {
        public ChapterService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
