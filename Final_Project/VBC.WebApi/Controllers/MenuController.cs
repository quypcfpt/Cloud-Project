using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VBC.DatabaseManagement.ViewModels;

namespace VBC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MenuController : ControllerBase
    {
        [HttpGet("getMenu")]
        public ActionResult GetMenu( )
        {
            using (StreamReader reader = new StreamReader("./Resource/admin_Menu.json"))
            {
                string json = reader.ReadToEnd();
                var menuList = JsonConvert.DeserializeObject<List<MenuViewModel>>(json);
                return Ok(menuList);
            }
         
        }
       
    }
}