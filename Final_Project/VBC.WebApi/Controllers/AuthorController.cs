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
    public class AuthorController : ControllerBase
    {
        private IAuthorService authorService;
        public AuthorController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet("getAll")]
        public async Task<ActionResult> GetAll()
        {
            try
            {
                var result = authorService.Get(q => q.Acitve == true).ToList();
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

        [HttpPost("create")]
        [Authorize]
        public async Task<ActionResult> Create([FromForm] AuthorViewModel model)
        {
            try
            {
                model.Acitve = true;
                var result = await authorService.CreateAsync(model);
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
    }
}