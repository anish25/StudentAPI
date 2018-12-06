using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    public class OrderModel : DbContext
    {
        public OrderModel(DbContextOptions<OrderModel> options) : base(options)
        {

        }
        //referene the student model for crud

        public DbSet<OrderModel> orders { get; set; }
    }

    
}
