using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket_System.BL.DTO.Department;
using Ticket_System.BL.DTO.Tickets;
using Ticket_System.DAL.Data.Models;
using Ticket_System.DAL.Repos.Departments;


namespace Ticket_System.BL.Managers.Departments
{
    public class DepartmentManger : IDepartmentManger
    {
        private readonly IDepartmentRepo _department;

        public DepartmentManger(IDepartmentRepo department)
        {
            _department = department;
        }
        public Department_With_Tickets_With_Number_of_Developer Get_Full_Info_Department_by_ID(int id)
        {
            Department? my_department = _department.GetDepartmentBy_ID(id);

            var opt_Tickets = my_department?.Tickets?.Select(t => new Ticket_with_ID_Description_numof_Developers(t.Id, t.Description,t.Developers.Count ));
            return new Department_With_Tickets_With_Number_of_Developer( my_department.Id,my_department.Name, opt_Tickets);

        }

    }
}
