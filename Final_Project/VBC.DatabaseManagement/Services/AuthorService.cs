using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using VBC.DatabaseManagement.Models.Entities;
using VBC.DatabaseManagement.ViewModels;
using VBC.Service;

namespace VBC.DatabaseManagement.Services
{
    public interface IAuthorService : IBaseService<Author, AuthorViewModel>
    {

    }

    public class AuthorService : BaseService<Author, AuthorViewModel>, IAuthorService
    {
        public AuthorService(IUnitOfWork unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
        }
    }
}
