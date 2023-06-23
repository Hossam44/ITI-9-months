
using Identitiy.Data.Context;
using Identitiy.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;

namespace Identitiy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            //to  verify that the recived token is valid by getting my secre and apply the hash in the token in claims 
            //and compare it with expected result 
            //we use this package to do that "microsoft.aspnetcore.authentication.jwtbeare"
            #region Autentication

            builder.Services.AddAuthentication(option =>
            {
                option.DefaultAuthenticateScheme = "CoolAuthentication";
                option.DefaultChallengeScheme = "CoolAuthentication";

            }).AddJwtBearer("CoolAuthentication", options=>
            {
                var secretKeyString = builder.Configuration.GetValue<string>("SecretKey") ?? string.Empty;
                var secretKeyInBytes = Encoding.ASCII.GetBytes(secretKeyString);
                var secretKey = new SymmetricSecurityKey(secretKeyInBytes);

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    IssuerSigningKey = secretKey,
                    ValidateAudience = false,
                    ValidateIssuer = false
                };

            });
            #endregion

            #region Autherization

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy(".net", policy => policy
                .RequireClaim(ClaimTypes.Role, ".net")
                .RequireClaim(ClaimTypes.NameIdentifier));

                options.AddPolicy("js", policy => policy
                .RequireClaim(ClaimTypes.Role, "js")
                );

            });

            #endregion

            #region DataBase

            var ConnectioString = builder.Configuration.GetConnectionString("Company");
            builder.Services.AddDbContext<CompanyContext>(optionsAction =>
            {
                optionsAction.UseSqlServer(ConnectioString);
            });

            #endregion


            #region Identity_Users

            builder.Services.AddIdentity<Employee,IdentityRole>().AddEntityFrameworkStores<CompanyContext>();

            #endregion

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}