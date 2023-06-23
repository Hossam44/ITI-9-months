using System.ComponentModel.DataAnnotations;

namespace TrainingCenter.Models
{
    public class Track
    {
        [Key]
        public int TrackID { get; set; }
        [Required,MaxLength(20)]
        public string? Name { get; set; }
        [Required,MaxLength(20)]
        public string? Description { get; set; }
        public List<Trainee>? Trainees { get; set; }
    }
}
