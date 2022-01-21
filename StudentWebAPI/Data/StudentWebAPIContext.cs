using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentWebAPI.Model;

namespace StudentWebAPI.Data
{
    public class StudentWebAPIContext : DbContext
    {
        public StudentWebAPIContext (DbContextOptions<StudentWebAPIContext> options)
            : base(options)
        {
        }

        public DbSet<StudentWebAPI.Model.Student> Student { get; set; }
    }
}
