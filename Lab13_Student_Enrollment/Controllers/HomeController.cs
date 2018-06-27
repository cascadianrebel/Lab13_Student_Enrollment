using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Lab13_Student_Enrollment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab13_Student_Enrollment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
