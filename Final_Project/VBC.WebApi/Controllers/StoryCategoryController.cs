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
    public class StoryCategoryController : ControllerBase
    {
        private IStoryCategoryService storyCategoryService;
        public StoryCategoryController(IStoryCategoryService storyCategoryService)
        {
            this.storyCategoryService = storyCategoryService;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var result = storyCategoryService.Get(q => q.Active == true).ToList();
                return Ok(new { data = result });
            }
            catch
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

        [HttpGet("getDetail/{id}")]
        public async Task<ActionResult> GetDetails(int id)
        {
            try
            {
                var result = storyCategoryService.Get(q => q.Id == id).FirstOrDefault();
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

        [HttpPut("edit")]
        [Authorize]
        public async Task<ActionResult> Edit([FromForm] StoryCategoryViewModel model)
        {
            try
            {
                model.Active = true;
                var result = await storyCategoryService.UpdateAsync(model);
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
        public async Task<ActionResult> Create([FromForm] StoryCategoryViewModel model)
        {
            try
            {
                model.Active = true;
                var result = await storyCategoryService.CreateAsync(model);
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
            catch(Exception e)
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

        [HttpDelete("delete")]
        [Authorize]
        public async Task<ActionResult> DeleteByID([FromQuery] int id)
        {
            try
            {
                var viewModel = storyCategoryService.Get(q => q.Id == id).FirstOrDefault();
                viewModel.Active = false;
                await storyCategoryService.UpdateAsync(viewModel);
                return Ok(new
                {
                    data = new
                    {
                        title = "Thành công!",
                        Msg = "Xóa thành công Event."
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
    }
}