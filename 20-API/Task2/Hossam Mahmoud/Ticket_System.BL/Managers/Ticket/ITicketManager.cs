using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.BL.DTO.Department;
using Ticket_System.BL.DTO.Tickets;

namespace Ticket_System.BL.Managers.Ticket
{
    public interface ITicketManager
    {
        IEnumerable<TicketReadDTO> GetAll();
        TicketWithDepartmentWithDevelopersDTO Get_Full_Info_Ticket_by_ID(int id);
    }
}
