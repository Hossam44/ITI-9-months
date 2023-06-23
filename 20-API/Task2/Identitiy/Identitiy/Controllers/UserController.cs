using Identitiy.Data.Models;
using Identitiy.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Identitiy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly UserManager<Employee> userManager;
        //private readonly ILogger logger;

        public UserController(IConfiguration configuration, UserManager<Employee> userManager )
        {
            this.configuration = configuration;
            this.userManager = userManager;
            //this.logger = logger;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<TokenDto>> Loging (LoginDto credentioals)
        {
            var user = await userManager.FindByNameAsync(credentioals.UserName);

            if(user == null)
            {
                return NotFound();
            }

            var isAuthenticated = await userManager.CheckPasswordAsync(user, credentioals.Password);

            if(!isAuthenticated)
            {
                return BadRequest();
            }
            var claims = await userManager.GetClaimsAsync(user);


            var secretKeyString = configuration.GetValue<string>("SecretKey") ?? string.Empty;
            var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
            var secretKey = new SymmetricSecurityKey(secretKeyInBytes);
             
            //combination of SecretKey and Hashing Algorithm
            var signiningCreditionals = new SigningCredentials(secretKey,SecurityAlgorithms.HmacSha256Signature);

            var expiry = DateTime.Now.AddDays(20);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: expiry,
                signingCredentials: signiningCreditionals
                );
            var tokenHandler = new JwtSecurityTokenHandler(); 
            var tokenString = tokenHandler.WriteToken(token);

            return new TokenDto(token: tokenString) ;
        }



        [HttpPost]
        [Route("regist_as_dotnet")]
        public async Task<ActionResult> registeration(RegistDto regist)
        {
            var employeeToadd = new Employee
            {
                UserName = regist.UserName,
                Department = regist.Department,
                Email = regist.Email
            };
            var result = await userManager.CreateAsync(employeeToadd,regist.Password);

            if(!result.Succeeded)
            {
                return Unauthorized();
            }

            var claimList = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,employeeToadd.Id),
                new Claim(ClaimTypes.Role,".net")
            };

            await userManager.AddClaimsAsync(employeeToadd,claimList);
            return NoContent(); 
        }


        [HttpPost]
        [Route("regist_as_js")]
        public async Task<ActionResult> registerationv2(RegistDto regist)
        {
            var employeeToadd = new Employee
            {
                UserName = regist.UserName,
                Department = regist.Department,
                Email = regist.Email
            };
            var result = await userManager.CreateAsync(employeeToadd, regist.Password);

            if (!result.Succeeded)
            {
                return Unauthorized();
            }
            var claimList = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier,employeeToadd.Id),
                new Claim(ClaimTypes.Role,"js")
            };

            await userManager.AddClaimsAsync(employeeToadd, claimList);
            return NoContent();
        }


        [HttpGet]
        [Route("GetUserInfo")]
        [Authorize]
        public ActionResult<string> GetUserInfo()
        {
            return Ok("getting data is ok");
        }

        [HttpGet]
        [Route("GetInfoFordotnet")]
        [Authorize(Policy = ".net")]
        public ActionResult<string> GetInfoFor_dotnet()
        {
            return Ok("getting data is ok from .net");
        }

        [HttpGet]
        [Route("GetInfoForjs")]
        [Authorize(Policy = "js")]
        public ActionResult<string> GetInfoFor_js()
        {
            return Ok("getting data is ok from js");
        }

    }
}
/*
eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyIiOiIiLCJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjJlNjY5N2M1LTI4YzktNDAyNi1iODI0LTE0NmZjMTdkMjY5OCIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL2VtYWlsYWRkcmVzcyI6Ikhvc3NhbW1ldHdhbGx5MTRAZ21haWwuY29tIiwiZXhwIjoxNjgxNjE1MDk5fQ.k4bhAdA3NrmptReWLNg7kkORIxAIYKijKtA1TB1HRFA
 * */