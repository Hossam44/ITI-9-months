using Identitiy.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Identitiy.Data.Context
{
    public class CompanyContext : IdentityDbContext<Employee>
    {
        public CompanyContext(DbContextOptions<CompanyContext>options):base(options) { }


    }
}
