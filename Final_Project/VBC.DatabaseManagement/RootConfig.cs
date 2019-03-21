using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VBC.DatabaseManagement.Identity;
using VBC.DatabaseManagement.Models.Entities;
using VBC.DatabaseManagement.Services;
using VBC.DatabaseManagement.ViewModels;
using VBC.Service;

namespace VBC.DatabaseManagement
{
    public static class RootConfig
    {
        //Giup config project nhanh hon khong lap di lap lai nhieu lan
        public static void Entry(IServiceCollection services, IConfiguration configuration)
        {
            //Cau hinh DBContext
            services.AddDbContext<Cloud_ProjectContext>(builder =>
            {
                builder.UseSqlServer(configuration.GetConnectionString("DbConnectionString"));
            });
            services.AddDbContext<VBCIdentityDBContext>(builder =>
            {
                builder.UseSqlServer(configuration.GetConnectionString("IdentityDbConnectionString"));
            });

            services.AddIdentity<ApplicationUser,ApplicationRole>()
               .AddEntityFrameworkStores<VBCIdentityDBContext>()
               .AddDefaultTokenProviders();

            var key = Encoding.Default.GetBytes("@everyone:VBCSecret!");

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });

            services.AddScoped(typeof(IdentityDbContext<ApplicationUser, ApplicationRole, string>), typeof(VBCUserManager));
            services.AddScoped(typeof(DbContext), typeof(Cloud_ProjectContext));

            //Cau hinh Services 
            #region Services Setting
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(IStoryCategoryService), typeof(StoryCategoryService));
            services.AddScoped(typeof(IStoryService), typeof(StoryService));
            services.AddScoped(typeof(IChapterService), typeof(ChapterService));
            services.AddScoped(typeof(IAspNetUserService), typeof(AspNetUserService));
            services.AddScoped(typeof(IAuthorService), typeof(AuthorService));
            #endregion

            // cau hinh AutoMapper
            #region Automaper Setting
            var mapperConfig = new MapperConfiguration(automapper =>
            {
                automapper.CreateMissingTypeMaps = true;

                //Cau hình ignore 
                automapper.CreateMap<StoryCategory, StoryCategoryViewModel>();
                automapper.CreateMap<StoryCategoryViewModel, StoryCategory>();

                automapper.CreateMap<Story, StoryViewModel>()
                .ForMember(q => q.AuthorName, p => p.MapFrom(src => src.Author.Name))
                .ForMember(q => q.CategoryName, p => p.MapFrom(src => src.Category.Name))
                .ForMember(q => q.CategorySeoName, p => p.MapFrom(src => src.Category.SeoName))
                .ForMember(q => q.PosterName, p => p.MapFrom(src => src.Poster.UserName))
                .ForMember(q => q.TotalChapters, p => p.MapFrom(src => src.Chapter.Any()? src.Chapter.Count():0))
                .ForMember(q => q.LastDateTimePostChapter, p => p.MapFrom(src => src.Chapter.Any() ? src.Chapter.Max(b => b.CreateTime).Value.ToString() : null ));
                automapper.CreateMap<StoryViewModel, Story>();

                automapper.CreateMap<Chapter, ChapterViewModel>();
                automapper.CreateMap<ChapterViewModel, Chapter>();

                automapper.CreateMap<Author, AuthorViewModel>();
                automapper.CreateMap<AuthorViewModel, Author>();

                automapper.CreateMap<AspNetUsers, AccountViewModel>();
                automapper.CreateMap<AccountViewModel, AspNetUsers>();

                automapper.CreateMap<AccountViewModel, AccountEditViewModel>();
                automapper.CreateMap<AccountEditViewModel, AccountViewModel>();

                automapper.CreateMap<ApplicationUser, AccountEditViewModel>();
                automapper.CreateMap<AccountEditViewModel, ApplicationUser>();

                automapper.CreateMap<Author, AuthorViewModel>();
                automapper.CreateMap<AuthorViewModel, Author>();
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton<IMapper>(mapper);
            #endregion
        }
    }
}
