using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using SchoolDataBaseTest.Models;

namespace SchoolDataBaseTest.Entities
{
    public class StudentInfoContext : DbContext
    {
        public StudentInfoContext(DbContextOptions<StudentInfoContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
