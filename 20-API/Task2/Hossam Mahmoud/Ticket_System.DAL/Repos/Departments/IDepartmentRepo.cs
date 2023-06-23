using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.DAL.Data.Models;

namespace Ticket_System.DAL.Repos.Departments
{
    public interface IDepartmentRepo
    {
        public Department? GetDepartmentBy_ID(int id);
    }
}
