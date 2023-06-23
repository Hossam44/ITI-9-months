using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using MathNet.Numerics;

namespace Day4.Areas.HR.Data
{

    public enum Gender { Male, Female }

    [Table("EmployeeInfo")]
    public class Employee
    {
        //[Key]
        //[ForeignKey("")]
        //[NotMapped]

        [Key]
        public int empID { get; set; }

        [Required(ErrorMessage = "Name Required!!")]
        [MaxLength(30, ErrorMessage = "Too long Name char!!!!!!")]
        [Display(Name = "EmployeeName")]
        public string Name { get; set; }


        [Required(ErrorMessage = "User Name Required!!")]
        [MaxLength(30, ErrorMessage = "Too long Name char!!!!!!")]
        [Display(Name = "User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "U Must Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required, DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime JoinDate { get; set; }

        [Required]
        [RegularExpression(@"^[0-9]+(\.[0-9]{1,2})$", ErrorMessage = "Valid Decimal number with maximum 2 decimal places.")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage = "Enter Email....")]
        [DataType(DataType.EmailAddress)]
        //[RegularExpression(@" ^\w + ([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "U have to re-type ur email...")]
        [Compare("Email", ErrorMessage = "Email Not match!!!")]
        //[NotMapped]
        public string ConfirmEmail { get; set; }

        [Required]
        [EnumDataType(typeof(Gender))]
        public Gender gender { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

    }
}
    