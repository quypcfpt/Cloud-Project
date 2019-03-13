using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VBC.DatabaseManagement.Services;

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

        [HttpGet("getChapterListbyStoryId")]
        public async Task<ActionResult> GetChapterListbyStoryId([FromQuery]int storyId)
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

    }
}