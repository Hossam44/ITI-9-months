using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.DAL.Data.Context;
using Ticket_System.DAL.Data.Models;

namespace Ticket_System.DAL.Repos.Tickets
{
    public class TicketRepo : ITicketsRepo
    {
        private readonly TicketContext _ticketContext;
         
        public TicketRepo(TicketContext ticketContext)
        {
            this._ticketContext = ticketContext;
        }
        public IEnumerable<Ticket> GetALL()
        {
            return _ticketContext.Set<Ticket>();
        }

        public Ticket? get_full_info_by_ID(int id)
        {
            return _ticketContext.Set<Ticket>().Include(t=>t.Department).Include(t=>t.Developers).Where(t => t.Id == id).FirstOrDefault();
        }

        public int SaveChanges()
        {
            return _ticketContext.SaveChanges(); 
        }
    }
}
