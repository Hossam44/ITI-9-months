using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticket_System.DAL.Data.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public string Tilte { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public int DepartmentID { get; set; }

        public Department Department { get; set; } = new Department();

        public ICollection<Developer> Developers { get; set; } = new List<Developer>();


    }
}
