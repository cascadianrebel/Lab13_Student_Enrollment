using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13_Student_Enrollment.Data
{
    public class Lab13_Student_EnrollementDbContext : DbContext
    {
        public Lab13_Student_EnrollementDbContext(DbContextOptions<Lab13_Student_EnrollementDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Course
            > Course { get; set; }
    }
}
