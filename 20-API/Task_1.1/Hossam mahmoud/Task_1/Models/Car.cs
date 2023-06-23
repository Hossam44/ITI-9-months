using System.ComponentModel.DataAnnotations;
using Task_1.Validators;

namespace Task_1.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        [StringLength(200)]
        public string? Description { get; set; }

        [DateInPast]
        public DateTime dateOfMade { get; set; }


        public string? Type { get; set; }

        public static List<Car> Cars = new List<Car>()
        {
        new Car { Id = 1, Name = "Car 1", Description = "This is car 1." },
        new Car { Id = 2, Name = "Car 2", Description = "This is car 2." },
        new Car { Id = 3, Name = "Car 3", Description = "This is car 3." }
        };
    }
}
