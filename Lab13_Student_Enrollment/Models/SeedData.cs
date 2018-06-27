using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab13_Student_Enrollment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Lab13_Student_Enrollment.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Lab13_Student_EnrollementDbContext(serviceProvider.GetRequiredService<DbContextOptions<Lab13_Student_EnrollementDbContext>>()))

            {
                // Look for any Courses.
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                     new Course
                     {
                         ID = 1,
                         Title = "401 - DotNet",
                         StartDate = DateTime.Parse("2018-1-11"),
                         Instructor = "Amanda"
                     }

                );
                context.SaveChanges();
            }
        }
    }
}
