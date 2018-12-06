using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Required]
        public DateTime Order_Date { get; set; }

        [Range(1,100000)]
        public int Total_Price { get; set; }

        [Required]
        public String Paid { get; set; }

        [Required]
        public int Student_Id { get; set; }
    }
}
