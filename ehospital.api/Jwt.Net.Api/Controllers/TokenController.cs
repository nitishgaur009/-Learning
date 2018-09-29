using EHosiptalBusiness;
using EHosiptalBusiness.Entity;
using Jwt.Net.Api.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Web.Http;


namespace Jwt.Net.Api.Controllers
{
    public class TokenController : ApiController
    {
        private HospitalContext _dbContext;

        public TokenController()
        {
            _dbContext = new HospitalContext();
        }

        [HttpPost]
        public IHttpActionResult Post(UserData user)
        {
            if (user != null)
            {
                var userData = _dbContext.UserLoginData.FirstOrDefault(u => u.Username == user.username && u.Password == user.password);

                if(userData != null)
                {
                    AuthenticatedDataModel authData = new AuthenticatedDataModel();
                    authData.username = userData.Username;
                    authData.token = GenerateToken(userData, authData);

                    authData.isAuthenticated = true;

                    return Ok(authData.token);
                }
                else
                {
                    return Unauthorized();
                }
            }
            else
            {
                return Unauthorized();
            }
        }

        private string GenerateToken(UserLoginData userData, AuthenticatedDataModel authData)
        {
            string security = "rewkjbwfrwehbfnmb1bbervewbfvfbdskfiuhisdhbdsjfsdbfvsdfvdsvfdsfndsvfbvdsbfvsdvfdsfdsfsdfsdf234234234234ewfrew4w432rewfdfdsfsdfds";
            SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.Default.GetBytes(security));

            List<Claim> claimsData = new List<Claim>();
            claimsData.Add(new Claim("username", userData.Username));
            claimsData.Add(new Claim("userid", userData.Id.ToString()));

            var userRoles = from r in _dbContext.UserRoles
                            join rd in _dbContext.Roles
                            on r.RoleId equals rd.RoleId
                            where r.UserId == userData.Id
                            select rd.RoleName;

            StringBuilder strRoles = new StringBuilder();
            foreach(var role in userRoles)
            {
                authData.roles.Add(role);

                strRoles.Append(role).Append(",");
            }

            claimsData.Add(new Claim("role", strRoles.ToString()));

            var token = new JwtSecurityToken(
                    issuer: "Jwt.Net.Api",
                    audience: "localhost:4200",
                    claims: claimsData,
                    notBefore: DateTime.UtcNow,
                    expires: DateTime.Now.AddMinutes(10),
                    signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256)
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
