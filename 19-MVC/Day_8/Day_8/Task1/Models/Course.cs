using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task1.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Topic { get; set; }

        [Required]
        public string CourseGrade { get; set; }

        [ForeignKey("Student")]
        public int stdid { get; set; }

        public Student Student { get; set; }
    }
}
