using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using VBC.DatabaseManagement.Identity;
using VBC.DatabaseManagement.Services;
using VBC.DatabaseManagement.Utils;
using VBC.DatabaseManagement.ViewModels;

namespace VBC.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private IAspNetUserService aspNetUserService;
        private UserManager<ApplicationUser> userManager;
        private IMapper mapper;
        private readonly IConfiguration configuration;
        private bool error = false;
        public AccountController(UserManager<ApplicationUser> userManager, IMapper mapper, IAspNetUserService aspNetUserService, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.aspNetUserService = aspNetUserService;
            this.configuration = configuration;
        }

        [HttpPost("login")]
        public async Task<ActionResult> Login([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
                var user = await userManager.FindByNameAsync(username);
                if (user != null)
                {
                    var isCorrect = await userManager.CheckPasswordAsync(user, password);
                    if (!isCorrect)
                    {
                        return Unauthorized(new
                        {
                            data = new
                            {
                                Msg = "Mật khẩu không đúng."
                            },
                        });
                    }
                    else
                    {
                        if (user.Status == (int)AccountStatusEnum.Active)
                        {
                            var token = await user.AuthorizeUserAsync(userManager, user);
                            var role = await userManager.GetRolesAsync(user);
                            string url = "/";
                            if (role.FirstOrDefault().Equals("System Manager"))
                            {
                                url = "/Story";
                            }
                            else if (role.FirstOrDefault().Equals("User"))
                            {
                                url = "/story/storyPoster";
                            }
                            else
                            {
                                return Ok(token);
                            }
                            return Ok(new
                            {
                                user = token,
                                homeUrl = url,
                            });
                        }
                        else if (user.Status == (int)AccountStatusEnum.Deactive)
                        {
                            return Unauthorized(new
                            {
                                data = new
                                {
                                    Msg = "Tài khoản đã bị khóa."
                                },
                            });
                        }
                        else
                        {
                            return Unauthorized(new
                            {
                                data = new
                                {
                                    Msg = "Tài khoản chưa xác nhận."
                                },
                            });
                        }
                    }
                }
                else
                {
                    return Unauthorized(new
                    {
                        data = new
                        {
                            Msg = "Username không đúng."
                        },
                    });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        Msg = "Có lỗi hệ thống!"
                    },
                });
            }
        }

        [HttpPost("register")]
        public async Task<ActionResult> Register([FromForm] AccountEditViewModel data)
        {
            try
            {
                // check existed user
                var existedUsername = await userManager.FindByNameAsync(data.UserName);
                if (existedUsername != null)
                {
                    return Ok(new
                    {
                        data = new
                        {
                            Msg = "Username da ton tai"
                        },
                        Success = false
                    });
                }


                var user = new ApplicationUser();
                mapper.Map(data, user);
                user.SecurityStamp = Guid.NewGuid().ToString();
                user.UserName = data.UserName;
                user.Status = 1;
                if (data.Password != data.ConfirmPassword)
                {
                    return BadRequest(new
                    {
                        data = new
                        {
                            Msg = "Xác thực password ko khớp"
                        },
                        Success = false
                    });
                }

                var result = await userManager.CreateAsync(user, data.Password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, data.RoleId);
                }
                return Ok(new
                {
                    data = new
                    {
                        Msg = "register thanh cong"
                    },
                    Success = true
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    title = "Có lỗi",
                    Msg = e.Message.ToString()
                });
            }

        }

        [HttpPut("update")]
        [Authorize]
        public async Task<ActionResult> UpdateProfile([FromForm] AccountEditViewModel data)
        {
            try
            {
                if (string.IsNullOrEmpty(data.Id))
                {
                    ClaimsPrincipal claims = this.User;
                    var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;
                    var currentUser = await userManager.FindByIdAsync(userId);
                    currentUser.FullName = data.FullName;
                    currentUser.Email = data.Email;
                    currentUser.PhoneNumber = data.PhoneNumber;
                    currentUser.AvartarUrl = data.AvartarUrl;

                    var currentUserRole = userManager.GetRolesAsync(currentUser).Result.FirstOrDefault();
                    if (!currentUserRole.Equals(data.RoleId))
                    {
                        await userManager.RemoveFromRoleAsync(currentUser, currentUserRole);
                        await userManager.AddToRoleAsync(currentUser, data.RoleId);
                    }
                    var result = await userManager.UpdateAsync(currentUser);
                    if (result.Succeeded)
                    {
                        return Ok(new
                        {
                            data = new
                            {
                                title = "Thanh cong!",
                                Msg = "Cap nhat thanh cong nguoi dung: " + currentUser.UserName
                            },
                            Success = true
                        });
                    }
                }
                else
                {
                    var currentUser = await userManager.FindByIdAsync(data.Id);
                    currentUser.FullName = data.FullName;
                    currentUser.Email = data.Email;
                    currentUser.PhoneNumber = data.PhoneNumber;
                    currentUser.AvartarUrl = data.AvartarUrl;
                    var currentUserRole = userManager.GetRolesAsync(currentUser).Result.FirstOrDefault();
                    if (!currentUserRole.Equals(data.RoleId))
                    {
                        await userManager.RemoveFromRoleAsync(currentUser, currentUserRole);
                        await userManager.AddToRoleAsync(currentUser, data.RoleId);
                    }
                    var result = await userManager.UpdateAsync(currentUser);
                    if (result.Succeeded)
                    {
                        return Ok(new
                        {
                            data = new
                            {
                                title = "Thanh cong!",
                                Msg = "Cap nhat thanh cong nguoi dung: " + currentUser.UserName
                            },
                            Success = true
                        });
                    }
                }
                return Ok(new
                {
                    data = new
                    {
                        title = "Có lỗi!",
                        Msg = "Người dùng không tồn tại"
                    },
                    Success = false
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Có lỗi!",
                        Msg = "Cập nhật không thành công"
                    },
                    Success = false
                });
            }

        }

        [HttpPut("change-password")]
        [Authorize]
        public async Task<ActionResult> ChangePassword([FromForm] ChangePasswordViewModel data)
        {
            try
            {
                ClaimsPrincipal claims = this.User;
                var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;

                var currentUser = await userManager.FindByIdAsync(userId);
                if (!data.NewPassword.Equals(data.ConfirmNewPassword))
                {
                    return Ok(new
                    {
                        data = new
                        {
                            Msg = "Tài khoản chưa xác nhận."
                        },
                        Success = false
                    });

                }
                var result = await userManager.ChangePasswordAsync(currentUser, data.CurrentPassword, data.NewPassword);
                if (result.Succeeded)
                {
                    return Ok(new
                    {
                        data = new
                        {
                            msg = "Không thành công. Xin vui lòng thử lại."
                        },
                        Success = true
                    });
                }
                return Ok(new
                {
                    data = new
                    {
                        msg = "Cap nhat khong thanh cong nguoi dung: " + currentUser.UserName
                    },
                    Success = false
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {

                    data = new
                    {
                        msg = "Có lỗi xảy ra! Vui lòng thử lại sau."
                    }
                });
            }
        }

        [HttpPost("getProfile")]
        [Authorize]
        public async Task<ActionResult> GetProfile([FromQuery]string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                ClaimsPrincipal claims = this.User;
                var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;
                var currentUser = await userManager.FindByIdAsync(userId);
                var userProfile = aspNetUserService.Get(q => q.Id.Equals(currentUser.Id)).FirstOrDefault();
                var result = new AccountEditViewModel();
                mapper.Map(userProfile, result);
                result.RoleId = userManager.GetRolesAsync(currentUser).Result.FirstOrDefault();
                return Ok(new { data = result });
            }
            var user = await userManager.FindByIdAsync(id);
            var profile = aspNetUserService.Get(q => q.Id.Equals(user.Id)).FirstOrDefault();
            var userViewModel = new AccountEditViewModel();
            mapper.Map(profile, userViewModel);
            userViewModel.RoleId = userManager.GetRolesAsync(user).Result.FirstOrDefault();
            return Ok(new { data = userViewModel });
        }

        [HttpPut("updateAvatar")]
        [Authorize]
        public async Task<ActionResult> UpdateProfile([FromQuery] string avatarUrl)
        {
            try
            {
                ClaimsPrincipal claims = this.User;
                var userId = claims.FindFirst(ClaimTypes.NameIdentifier).Value;
                var currentUser = await userManager.FindByIdAsync(userId);
                currentUser.AvartarUrl = avatarUrl;
                await userManager.UpdateAsync(currentUser);
                return Ok(new
                {
                    title = "Thay đổi thành công",
                    message = $"Ban da update thanh cong User co ten la: {currentUser.UserName}"
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    title = "Có lỗi",
                    message = e.Message.ToString()
                });

            }
        }



        [HttpPost("retrivePassword")]
        [AllowAnonymous]
        public async Task<ActionResult> RetrivePassword([FromQuery] string username, [FromQuery] string email)
        {
            try
            {

                var userRetrivePassword = await userManager.FindByNameAsync(username);
                if (userRetrivePassword != null)
                {
                    //Reset Password
                    var newPassword = configuration.GetSection("ResetNewPassword").Get<string>();

                    var token = await userManager.GeneratePasswordResetTokenAsync(userRetrivePassword);
                    var result = await userManager.ResetPasswordAsync(userRetrivePassword, token, newPassword);

                    //Reset Password Success
                    if (result.Succeeded)
                    {
                        //Send Email
                        var fromEmail = configuration.GetSection("FromEmail").Get<string>();
                        var emailPassword = configuration.GetSection("EmailPassword").Get<string>();
                        var smtpClient = configuration.GetSection("SmtpClient").Get<string>();
                        var port = configuration.GetSection("ClientPort").Get<string>();
                        var displayName = configuration.GetSection("DsiplayNameEmail").Get<string>();
                        var subject = configuration.GetSection("EmailSubject").Get<string>();
                        var urlTemplate = configuration.GetSection("UrlTemplate").Get<string>();

                        var login = new NetworkCredential(fromEmail, emailPassword);
                        var client = new SmtpClient(smtpClient);
                        client.Port = Convert.ToInt32(port);
                        client.EnableSsl = true;
                        client.Credentials = login;
                        var msg = new MailMessage { From = new MailAddress(fromEmail, displayName, Encoding.UTF8) };
                        msg.To.Add(new MailAddress(email.ToString()));
                        msg.Subject = subject + username.ToString();
                        string templateEmail = string.Empty;
                        using (StreamReader reader = new StreamReader(urlTemplate))
                        {
                            templateEmail = reader.ReadToEnd();
                        }
                        templateEmail = templateEmail.Replace("{username}", username);
                        templateEmail = templateEmail.Replace("{password}", newPassword);
                        msg.Body = templateEmail;
                        msg.BodyEncoding = Encoding.UTF8;
                        msg.IsBodyHtml = true;
                        msg.Priority = MailPriority.Normal;
                        msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                        client.SendCompleted += new SendCompletedEventHandler(sendCompleteCallback);
                        string userstate = "sending...";
                        client.SendAsync(msg, userstate);
                        return Ok(new
                        {
                            data = new
                            {
                                title = "Lấy lại Mật khẩu thành công!",
                                Msg = "Kiểm tra email để nhận mật khẩu mới."
                            },
                            Success = true
                        });
                    }
                    else
                    {
                        return Ok(new
                        {
                            data = new
                            {
                                title = "Có lỗi xảy ra!",
                                Msg = "Có lỗi xảy ra!"
                            },
                            Success = false
                        });
                    }
                }
                else
                {
                    return Ok(new
                    {
                        data = new
                        {
                            title = "Tên người dùng không đúng",
                            Msg = "Tên tài khoản không đúng!"
                        },
                        Success = false
                    });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    data = new
                    {
                        title = "Có lỗi xảy ra!",
                        Msg = e.Message

                    },
                    Success = false
                });
            }
        }

        private void sendCompleteCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                //MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = true;
            }
            if (e.Error != null)
            {
                //MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                error = true;
            }
            else
            {
                //MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                error = false;
            }
        }

        [HttpPut("updateStatus")]
        [Authorize]
        public async Task<ActionResult> UpdateStatus([FromQuery] string userId, [FromQuery]int status)
        {
            try
            {
                var user = aspNetUserService.Get(q => q.Id.Equals(userId)).FirstOrDefault();
                if (!Enum.IsDefined(typeof(AccountStatusEnum), status))
                {
                    return Ok(new
                    {
                        data = new
                        {
                            title = "Không thành công!",
                            Msg = "Thay đổi trạng thái không thành công!"
                        },
                        Success = false
                    });
                }
                else
                {
                    user.Status = status;
                    await aspNetUserService.UpdateAsync(user);
                    return Ok(new
                    {
                        data = new
                        {
                            title = "Thành công!",
                            Msg = "Thay đổi trạng thái thành công!"
                        },
                        Success = true
                    });
                }
            }
            catch (Exception e)
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

        [HttpGet("getAccountsByFilterSystemAdministrator")]
        [Authorize]
        public async Task<ActionResult> GetAccountsByFilterSystemAdministrator([FromQuery] string roleId, [FromQuery] int status)
        {
            try
            {
                var userAccounts = aspNetUserService.Get();
                if (!string.IsNullOrEmpty(roleId))
                {
                    userAccounts = aspNetUserService.Get(q =>
                    q.AspNetUserRoles.Where(p => p.RoleId.Equals(roleId)).Select(p => p.UserId)
                    .Contains(q.Id));
                }

                if (status != -1)
                {
                    userAccounts = userAccounts.Where(q => q.Status == status);
                }
                var result = userAccounts;
                return Ok(new
                {
                    data = result,
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
                        Msg = "Failed to update!"
                    },
                    Success = false
                });
            }
        }

    }
}