using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab13_Student_Enrollment.Models;
using Lab13_Student_Enrollment.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab13_Student_Enrollment.Controllers
{
    public class CourseController : Controller
    {
        private Lab13_Student_EnrollementDbContext _context;

        public CourseController(Lab13_Student_EnrollementDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Queries the db for the titles
        /// </summary>
        /// <param name="courseTitle"></param>
        /// <param name="searchString"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Index(string courseTitle, string searchString)
        {
            IQueryable<string> titleQuery = from m in _context.Course
                                            orderby m.Title
                                            select m.Title;

            var coursesQuery = from m in _context.Course
                          select m;
            if (!String.IsNullOrEmpty(searchString))
            {
                coursesQuery = coursesQuery.Where(s => s.Title.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(courseTitle))
            {
                coursesQuery = coursesQuery.Where(x => x.Title == courseTitle);
            }

            var courseTitleVM = new CourseTitleViewModel();
            courseTitleVM.Titles = new SelectList(await titleQuery.Distinct().ToListAsync());
            courseTitleVM.Courses = await coursesQuery.ToListAsync();

            return View(courseTitleVM);
        }

        // GET: Course/Create
        public async Task<IActionResult> Create()
        {
            ViewData["Create"] = await _context.Course.Select(c => c)
                .ToListAsync();
            return View();
        }




    }
}
