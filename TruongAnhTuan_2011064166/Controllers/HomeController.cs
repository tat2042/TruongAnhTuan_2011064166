using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using TruongAnhTuan_2011064166.Models;
using TruongAnhTuan_2011064166.ViewModels;

namespace TruongAnhTuan_2011064166.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcomingCourses = _dbContext.Courses
               .Include(c => c.Lecturer)
                .Include(c => c.Category)
              .Where(c => c.DateTime > DateTime.Now);

            var viewModel = new CoursesViewModel
            {
                UpcomingCourse = upcomingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}