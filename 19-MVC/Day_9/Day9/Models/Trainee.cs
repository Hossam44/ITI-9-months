using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TrainingCenter.Models
{
    public enum Gender { male,female };
    public class Trainee
    {
        [Key]
        public int TraineeID { get; set; }
        [Required,MaxLength(20)]
        public string? Name { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        [Required]
        public string? MobileNo { get; set; }
        [Required]
        public DateTime? DateTime { get; set; }
        public Track? track { get; set; }
      
        public List<Course>? courses { get; set; }
    }
}
