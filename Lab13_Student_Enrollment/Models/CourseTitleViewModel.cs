using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab13_Student_Enrollment.Models
{
    public class CourseTitleViewModel
    {
        public List<Course> Courses { get; set; }
        public SelectList Titles { get; set; }
        public string CourseTitle { get; set; }
    }
}
