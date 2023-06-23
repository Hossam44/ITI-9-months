using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.BL.DTO.Department;
using Ticket_System.BL.DTO.Developers;
using Ticket_System.BL.DTO.Tickets;
using Ticket_System.DAL.Data.Models;
using Ticket_System.DAL.Repos.Tickets;

namespace Ticket_System.BL.Managers.Ticket
{
    public class TicketManager : ITicketManager
    {
        private readonly ITicketsRepo ticketsRepo;

        public TicketManager(ITicketsRepo ticketsRepo)
        {
            this.ticketsRepo = ticketsRepo;
        }
        public IEnumerable<TicketReadDTO> GetAll()
        {
            var Tickets = ticketsRepo.GetALL();
            return Tickets.Select(t =>
                new TicketReadDTO(id: t.Id, title: t.Tilte));
        }

        public TicketWithDepartmentWithDevelopersDTO Get_Full_Info_Ticket_by_ID(int id)
        {
            var _ticket = ticketsRepo.get_full_info_by_ID(id);

            return new TicketWithDepartmentWithDevelopersDTO
                (
                    Id: _ticket.Id,
                    Name: _ticket.Tilte,
                    Description: _ticket.Description,
                    departmentReadDTO: new DepartmentReadDTO(name: _ticket.Department.Name),
                    developerReadDTO: _ticket.Developers.Select(t => new DeveloperReadDTO(name: t.Name))
                    );
        }



    }
}
