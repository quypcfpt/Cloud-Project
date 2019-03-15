using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VBC.DatabaseManagement.Models.Entities;
using VBC.DatabaseManagement.ViewModels;
using VBC.Service;

namespace VBC.DatabaseManagement.Services
{

    public interface IAspNetUserService : IBaseService<AspNetUsers, AccountViewModel>
    {

    }
    public class AspNetUserService: BaseService<AspNetUsers, AccountViewModel>, IAspNetUserService
    {
        public AspNetUserService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
