using Microsoft.AspNetCore.Identity;

namespace Identitiy.Data.Models
{
    public class Employee : IdentityUser
    {
        public string? Department { get; set; } 
    }
}
