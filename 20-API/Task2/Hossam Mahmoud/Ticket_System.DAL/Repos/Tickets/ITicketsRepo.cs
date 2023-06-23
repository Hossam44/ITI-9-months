using Ticket_System.DAL.Data.Models;

namespace Ticket_System.DAL.Repos.Tickets
{
    public interface ITicketsRepo
    {
        IEnumerable<Ticket> GetALL();
        int SaveChanges();
        Ticket get_full_info_by_ID(int id);
    }
}
