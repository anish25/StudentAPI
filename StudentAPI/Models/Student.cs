using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    [Table("student")]
    public class Student
    {
        
        [key]
        public int StudentId { get; set; }
        [Required]
        public String FirstName { get; set; }
        [Required]
        public String LastName { get; set; }
        [Required]
        public String Email { get; set; }
        [Range(0,9)]
        public int Phone_No { get; set; }
        [Required]
        public String Address { get; set; }
        [Required]
        public String city { get; set; }
        [Required]
        public String country { get; set; }
    }
}
