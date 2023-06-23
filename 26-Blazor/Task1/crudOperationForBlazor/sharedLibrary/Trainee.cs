using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharedLibrary
{
    public class Trainee
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        public GenderType Gender { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string MobileNo { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        public bool IsGraduated { get; set; }

        [Required]
        public int TrackId { get; set; }

        public Track Track { get; set; }
    }

    public enum GenderType
    {
        Man,
        Woman
    }
}
