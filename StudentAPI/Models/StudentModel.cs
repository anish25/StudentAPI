using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAPI.Models
{
    public class StudentModel : DbContext
    {
        public StudentModel(DbContextOptions<StudentModel> options) : base(options) {

        }
        //referene the student model for crud

        public DbSet<Student> Students { get; set; }
    }
}
