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
    public class ChapterController : ControllerBase
    {
        private IChapterService chapterService;
        public ChapterController(IChapterService chapterService)
        {
            this.chapterService = chapterService;
        }

        [HttpGet("getChapterListbyStoryId/{storyId}")]
        public async Task<ActionResult> GetChapterListbyStoryId(int storyId)
        {
            try
            {
                var result = chapterService.Get(q => q.Active == true && q.StoryId == storyId).ToList();
                return Ok(new { data = result});
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Error",
                        Msg = "Fail to load chapter of Story list!"
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
                var viewModel = chapterService.Get(q => q.Id == eventId).FirstOrDefault();

                viewModel.IsApproved = statusNum;
                await chapterService.UpdateAsync(viewModel);
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
                var result = chapterService.Get(q => q.Id == id).FirstOrDefault();
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


        [HttpPost("create")]
        [Authorize]
        public async Task<ActionResult> Create([FromForm] ChapterViewModel model)
        {
            try
            {
                model.Active = true;
                model.IsApproved = 0;
                model.TotalVisit = 0;
                model.CreateTime = DateTime.Now;
                var result = await chapterService.CreateAsync(model);
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

        [HttpPut("edit")]
        [Authorize]
        public async Task<ActionResult> Edit([FromForm] ChapterViewModel model)
        {
            try
            {

                var currentmodel = await chapterService.FirstOrDefaultAsync(q => q.Id == model.Id);
                currentmodel.Name = model.Name;
                currentmodel.Detail = model.Detail;
                currentmodel.Position = model.Position;
                currentmodel.IsApproved = 0;
                var result = await chapterService.UpdateAsync(currentmodel);
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
    }
}