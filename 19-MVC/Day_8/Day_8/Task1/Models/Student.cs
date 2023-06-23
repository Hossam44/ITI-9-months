using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace Task1.Models
{

    public enum Gender
    {
        Male,
        Female
    }
    public class Student
    { 
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public Gender StudentGender { get; set; }

        [Required]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        public ICollection<Course> Courses { get; set; }

    }
}