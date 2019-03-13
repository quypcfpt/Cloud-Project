using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VBC.DatabaseManagement.Services;
using VBC.DatabaseManagement.ViewModels;

namespace VBC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryController : ControllerBase
    {
        private IStoryService storyService;
        public StoryController(IStoryService storyService)
        {
            this.storyService = storyService;
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

        [HttpPut("edit")]
        public async Task<ActionResult> Edit([FromForm] StoryViewModel model)
        {
            try
            {
                var result = await storyService.UpdateAsync(model);
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
        public async Task<ActionResult> Create([FromForm] StoryViewModel model)
        {
            try
            {
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
            catch
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

        [HttpPut("updateStatus")]
        [Authorize]
        public async Task<ActionResult> UpdateStatus([FromQuery] int eventId, [FromQuery] bool statusNum)
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

    }
}