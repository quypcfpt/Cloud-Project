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
using VBC.DatabaseManagement.ViewModels;

namespace VBC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private UserManager<ApplicationUser> userManager;
        private IMapper mapper;

        public AccountController(UserManager<ApplicationUser> userManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromQuery] string username, [FromQuery] string password)
        {
            var user = await userManager.FindByNameAsync(username);
            if (user != null)
            {
                var isCorrect = await userManager.CheckPasswordAsync(user, password);
                if (!isCorrect)
                {
                    return Unauthorized();
                }
                else
                {
                    var token = await user.AuthorizeUserAsync(userManager, user);
                    return Ok(token);
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromBody] AccountEditViewModel data)
        {
            // check existed user
            var existedUsername = await userManager.FindByNameAsync(data.UserName);
            if (existedUsername != null)
            {
                return Ok(new { message = "Username da ton tai" });
            }


            var user = new ApplicationUser();
            mapper.Map(data, user);
            user.SecurityStamp = Guid.NewGuid().ToString();
            user.UserName = data.UserName;

            if (data.Password != data.ConfirmPassword)
            {
                return BadRequest(new { message ="Xác thực password ko khớp"});
            }

            var result = await userManager.CreateAsync(user, data.Password);
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(user, data.RoleId);
            }
            return Ok(new { message = "register thanh cong" });

        }

        [HttpPut("update")]
        [Authorize]
        public async Task<ActionResult> UpdateProfile([FromBody] AccountEditViewModel data)
        {
            ClaimsPrincipal claims = this.User;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

            var currentUser = await userManager.FindByIdAsync(userId);
            mapper.Map(data, currentUser);
            await userManager.UpdateAsync(currentUser);

            return Ok(new
            {
                message = $"Ban da update thanh cong User co ten la: {currentUser.UserName}"
            });
        }

        [HttpPut("change-password")]
        [Authorize]
        public async Task<ActionResult> ChangePassword([FromBody] ChangePasswordViewModel data)
        {
            ClaimsPrincipal claims = this.User;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

            var currentUser = await userManager.FindByIdAsync(userId);
            if (!data.NewPassword.Equals(data.ConfirmNewPassword))
            {
                return BadRequest(new { message = "Xác thực pasword khong chính xác" });

            }
            var result = await userManager.ChangePasswordAsync(currentUser, data.CurrentPassword, data.NewPassword);
            if (result.Succeeded)
            {
                return Ok(new
                {
                    message = $"Ban da doi password thanh cong User co ten la: {currentUser.UserName}"
                });
            }
            else
            {
                return Ok(new
                {
                    message = result.ToString()
                });
            }
        }

        [HttpGet("getProfile")]
        [Authorize]
        public async Task<ActionResult> GetProfile()
        {
            ClaimsPrincipal claims = this.User;
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

            var currentUser = await userManager.FindByIdAsync(userId);
            var currentUserVM = new AccountViewModel();
            mapper.Map(currentUser, currentUserVM);
            return Ok(currentUserVM);
        }
    }
}