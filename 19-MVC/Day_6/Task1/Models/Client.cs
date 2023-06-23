using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [Required,MinLength(2),MaxLength(30)]
        public string Name { get; set; }

        [Required, MinLength(5), MaxLength(20),DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }
        public string Adress { get; set; }


    }
}