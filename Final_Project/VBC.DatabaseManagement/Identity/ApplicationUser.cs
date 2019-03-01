using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace VBC.DatabaseManagement.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base()  { }

        public string FullName { get; set; }
        public string AvartarUrl { get; set; }

        /// <summary>
        /// Cai ham nay co the tao ra cho controller 1 cai accesstoken de ho tra ve cho nguoi dung
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="user"></param>
        /// <returns></returns> 
        public async Task<dynamic> AuthorizeUserAsync(UserManager<ApplicationUser> userManager, ApplicationUser user)
        {
            //đay la buoc danh cau hinh Claim (payload) cho token
            var userRoles = await userManager.GetRolesAsync(user);

            var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Name, user.UserName)
            };

            foreach(var userRole in userRoles)
            {
                claims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            //Cấu hình Signature
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.Default.GetBytes("@everyone:VBCSecret!");
            var issuser = "http://votechain.asia";
            var audience = "http://votechain.asia";

            var tokenDescription = new SecurityTokenDescriptor()
            {
                Issuer = issuser,
                Audience = audience,
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(7).AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescription);
            var tokenString = tokenHandler.WriteToken(token);

            return new
            {
                token = tokenString,
                validTo = token.ValidTo,
                valifFrom = token.ValidFrom
            };
        }
    }
}
