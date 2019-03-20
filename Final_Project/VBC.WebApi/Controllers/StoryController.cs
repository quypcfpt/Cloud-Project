using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using VBC.DatabaseManagement.Identity;
using VBC.DatabaseManagement.Services;
using VBC.DatabaseManagement.ViewModels;

namespace VBC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {

        private UserManager<ApplicationUser> userManager;
        private IMapper mapper;
        private IStoryService storyService;
        public StoryController(IStoryService storyService, UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            this.storyService = storyService;
            this.userManager = userManager;
            this.mapper = mapper;
        }

        [HttpGet("searchStoryByLikeName")]
        public async Task<ActionResult> GetStoryByLikeName([FromQuery]string storyName)
        {
            try
            {
                return Ok(this.storyService.GetStoryNameLike(storyName));
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("getAll")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var result = storyService.Get(q => q.Active == true).ToList();
                return Ok(new { data = result });
            }
            catch(Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to load organization list!"
                    },
                    Success = false
                });
            }

        }

        [HttpGet("getStoriesByCategory")]
        public async Task<ActionResult> GetStoriesByCategory([FromQuery] string cateSeoName)
        {
            try
            {
                var result = storyService.Get(q => q.Active == true && q.Category.SeoName.Equals(cateSeoName)).ToList();
                return Ok(new { data = result });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to load organization list!"
                    },
                    Success = false
                });
            }

        }

        [HttpPut("edit")]
        [Authorize]
        public async Task<ActionResult> Edit([FromForm] StoryViewModel model)
        {
            try
            {

                var currentmodel = await storyService.FirstOrDefaultAsync(q => q.Id == model.Id);
                currentmodel.Status = model.Status;
                currentmodel.Name = model.Name;
                currentmodel.Description = model.Description;
                currentmodel.ImageUrl = model.ImageUrl;
                currentmodel.CategoryId = model.CategoryId;
                currentmodel.AuthorId   = model.AuthorId;
                currentmodel.Approved = 0;
                var result = await storyService.UpdateAsync(currentmodel);



                return Ok(new
                {
                    data = new
                    {
                        title = "Success",
                        Msg = "Edit Success!"
                    },
                    Success = true
                });
            }
            catch
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to update!"
                    },
                    Success = false
                });
            }
        }


        [HttpPost("create")]
        [Authorize]
        public async Task<ActionResult> Create([FromForm] StoryViewModel model)
        {
            try
            {
                var currentUser = await GetCurrentUserAsync();

                model.Active = true;
                model.Approved = 0;
                model.TotalVisit = 0;
                model.PosterId = currentUser.Id;
                var result = await storyService.CreateAsync(model);
                return Ok(new
                {
                    data = new
                    {
                        title = "Success",
                        Msg = "Create success!"
                    },
                    Success = true
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to create!"
                    },
                    Success = false
                });
            }
        }

        [HttpPut("updateApproved")]
        [Authorize]
        public async Task<ActionResult> UpdateApproved([FromQuery] int eventId, [FromQuery] int statusNum)
        {
            try
            {
                var viewModel = storyService.Get(q => q.Id == eventId).FirstOrDefault();

                viewModel.Approved = statusNum;
                await storyService.UpdateAsync(viewModel);
                return Ok(new
                {
                    data = new
                    {
                        title = "Thành công!",
                        Msg = "Cập nhật trạng thái thành công Event."
                    },
                    Success = true
                });
            }
            catch
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Có lỗi!",
                        Msg = "Có lỗi xảy ra!"
                    },
                    Success = false

                });
            }

        }

        [HttpPut("updateStatus")]
        [Authorize]
        public async Task<ActionResult> UpdateStatus([FromQuery] int eventId, [FromQuery] int statusNum)
        {
            try
            {
                var viewModel = storyService.Get(q => q.Id == eventId).FirstOrDefault();

                viewModel.Status = statusNum;
                await storyService.UpdateAsync(viewModel);
                return Ok(new
                {
                    data = new
                    {
                        title = "Thành công!",
                        Msg = "Cập nhật trạng thái thành công Event."
                    },
                    Success = true
                });
            }
            catch
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Có lỗi!",
                        Msg = "Có lỗi xảy ra!"
                    },
                    Success = false

                });
            }

        }

        [HttpGet("getDetail/{id}")]
        public async Task<ActionResult> GetDetails(int id)
        {
            try
            {
                var result = storyService.Get(q => q.Id == id).FirstOrDefault();
                return Ok(new { data = result });
            }
            catch
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to get details!"
                    },
                    Success = false
                });
            }
        }

        [HttpGet("getDetailbySeoName/{seoName}")]
        public async Task<ActionResult> GetDetailsbySeoName(string seoName)
        {
            try
            {
                var result = storyService.Get(q => q.SeoName.Equals(seoName) && q.Active== true && q.Approved == 1).FirstOrDefault();
                result.TotalVisit = result.TotalVisit + 1;
                await storyService.UpdateAsync(result);
                return Ok(new { data = result });
            }
            catch
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to get details!"
                    },
                    Success = false
                });
            }
        }

        [HttpDelete("delete")]
        [Authorize]
        public async Task<ActionResult> DeleteByID([FromQuery] int id)
        {
            try
            {
                var viewModel = storyService.Get(q => q.Id == id).FirstOrDefault();
                viewModel.Active = false;
                await storyService.UpdateAsync(viewModel);
                return Ok(new
                {
                    data = new
                    {
                        title = "Thành công!",
                        Msg = "Xóa thành công truyện."
                    },
                    Success = true
                });

            }
            catch
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Có lỗi!",
                        Msg = "Có lỗi xảy ra!"
                    },
                    Success = false

                });
            }

        }


        [HttpGet("getAllActiveByPoster")]
        [Authorize]
        public async Task<ActionResult> GetAllActiveByPoster()
        {
            try
            {
                var currentUser = await GetCurrentUserAsync();

                var result = storyService.Get(q => q.Active == true && q.PosterId.Equals(currentUser.Id)).ToList();
                return Ok(new { data = result });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to load organization list!"
                    },
                    Success = false
                });
            }

        }

        [HttpGet("getStoriesNewChapters")]
        public async Task<ActionResult> GetStoriesNewChapters()
        {
            try
            {
                var result = storyService.Get(q => q.Active == true && q.Approved == 1).OrderByDescending(a => a.LastDateTimePostChapter).ToList();
                return Ok(new { data = result });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to load organization list!"
                    },
                    Success = false
                });
            }

        }

        [HttpGet("getStoriesTopView")]
        public async Task<ActionResult> GetStoriesTopView()
        {
            try
            {
                var result = storyService.Get(q => q.Active == true && q.Approved == 1).OrderByDescending(a => a.TotalVisit).ToList();
                return Ok(new { data = result });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to load organization list!"
                    },
                    Success = false
                });
            }

        }

        private async Task<ApplicationUser> GetCurrentUserAsync()
        {
            ClaimsPrincipal claims = this.User;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

            var currentUser = await userManager.FindByIdAsync(userId);

            return currentUser;
        }
    }
 
   
}