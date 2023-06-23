using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.BL.DTO.Tickets;

namespace Ticket_System.BL.DTO.Department
{
    public record Department_With_Tickets_With_Number_of_Developer
        (
            int Id,
            string Name,
            IEnumerable<Ticket_with_ID_Description_numof_Developers> Tickets
        );
}
