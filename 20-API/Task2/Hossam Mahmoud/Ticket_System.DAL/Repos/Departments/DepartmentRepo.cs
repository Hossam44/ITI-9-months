using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.DAL.Data.Context;
using Ticket_System.DAL.Data.Models;
using Ticket_System.DAL.Repos.Tickets;

namespace Ticket_System.DAL.Repos.Departments
{
    public class DepartmentRepo : IDepartmentRepo
    {
        private readonly TicketContext ticket;

        public DepartmentRepo(TicketContext ticket)
        {
            this.ticket = ticket;
        }

        public Department? GetDepartmentBy_ID(int id)
        {
            return ticket.Departments?.Where(D => D.Id == id).Include(d => d.Tickets).ThenInclude(t => t.Developers).FirstOrDefault();
        }

    }
}
