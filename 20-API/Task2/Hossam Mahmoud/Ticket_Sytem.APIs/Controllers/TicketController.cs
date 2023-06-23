using Microsoft.AspNetCore.Mvc;
using Ticket_System.BL.DTO.Department;
using Ticket_System.BL.DTO.Tickets;
using Ticket_System.BL.Managers.Departments;
using Ticket_System.BL.Managers.Ticket;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ticket_System.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketManager ticketManager;
        private readonly IDepartmentManger departmentManger;

        public TicketController(ITicketManager ticketManager,IDepartmentManger departmentManger)
        {
            this.ticketManager = ticketManager;
            this.departmentManger = departmentManger;
        }
        // GET: api/<TicketController>
        [HttpGet]
        public ActionResult<List<TicketReadDTO>> Get()
        {
            return ticketManager.GetAll().ToList();
        }

        // GET api/<TicketController>/5
        [HttpGet("{id}")]
        public ActionResult<TicketWithDepartmentWithDevelopersDTO> Get(int id)
        {
            return ticketManager.Get_Full_Info_Ticket_by_ID(id);
        }


        [HttpGet("department/{id}")]
        public ActionResult<Department_With_Tickets_With_Number_of_Developer> GetDepartment(int id)
        {
            return departmentManger.Get_Full_Info_Department_by_ID(id);
        }


    }
}
