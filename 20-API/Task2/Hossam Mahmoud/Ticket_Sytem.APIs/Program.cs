
using Microsoft.EntityFrameworkCore;
using Ticket_System.BL.Managers;
using Ticket_System.BL.Managers.Departments;
using Ticket_System.BL.Managers.Ticket;
using Ticket_System.DAL.Data.Context;
using Ticket_System.DAL.Repos.Departments;
using Ticket_System.DAL.Repos.Tickets;

namespace Ticket_System.APIs
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


            var ConnectionString = "Server=.; Database=Ticket; Trusted_Connection=true; Encrypt=false;"!;
            builder.Services.AddDbContext<TicketContext>(options=>options.UseSqlServer(ConnectionString));

            

            builder.Services.AddScoped<ITicketsRepo,TicketRepo>();

            builder.Services.AddScoped<ITicketManager,TicketManager >();

            builder.Services.AddScoped<IDepartmentRepo, DepartmentRepo>();

            builder.Services.AddScoped<IDepartmentManger, DepartmentManger>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}