using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.BL.DTO.Department;
using Ticket_System.BL.DTO.Developers;

namespace Ticket_System.BL.DTO.Tickets
{
    public record TicketWithDepartmentWithDevelopersDTO
        (
        int Id, 
        string Name,
        string Description,
        DepartmentReadDTO departmentReadDTO,
        IEnumerable<DeveloperReadDTO>? developerReadDTO
        );
 
}
