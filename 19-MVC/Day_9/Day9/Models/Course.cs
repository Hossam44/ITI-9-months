using System.ComponentModel.DataAnnotations;

namespace TrainingCenter.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required,MaxLength(20)]
        public string? Topic { get; set; }
        [Required,MaxLength(20)]
        public string? Grade { get; set; }
       public Trainee? trainee { get; set; }
    }
}
