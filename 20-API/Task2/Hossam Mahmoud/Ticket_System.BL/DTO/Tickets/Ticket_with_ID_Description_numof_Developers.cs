using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.BL.DTO.Department;
using Ticket_System.BL.DTO.Developers;

namespace Ticket_System.BL.DTO.Tickets
{
    public record Ticket_with_ID_Description_numof_Developers
       (
        int Id,
        string Description,
        int num_of_Developer
        );
}
