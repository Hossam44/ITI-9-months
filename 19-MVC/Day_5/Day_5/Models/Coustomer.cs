using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Day_5.Models
{
    public enum Gender { Male, Female }
    [Table("Coustomer")]
    public class Coustomer
    {
        [Key]
        public int CoustomerID { get; set; }

        [Required(ErrorMessage = "Name Required!!")]
        [MaxLength(30, ErrorMessage = "Too long Name char!!!!!!")]
        [Display(Name = "CoustomerName")]
        public string Name { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [Required(ErrorMessage = "Enter Email....")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        public virtual IList<Order> Orders { get; set; }

    }
}