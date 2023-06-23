using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.BL.DTO.Department;

namespace Ticket_System.BL.Managers.Departments
{
    public interface IDepartmentManger 
    {
        Department_With_Tickets_With_Number_of_Developer Get_Full_Info_Department_by_ID(int id);

    }
}
