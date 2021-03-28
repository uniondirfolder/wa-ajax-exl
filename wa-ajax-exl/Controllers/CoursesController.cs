using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using wa_ajax_exl.Models;

namespace wa_ajax_exl.Controllers
{
    public class CoursesController : Controller
    {
        // GET: Courses
        public ActionResult Index(string name)
        {
            return View((object)(name));
        }

        
        public ActionResult FindCourse(string name) 
        {
            CourseRepository db = new CourseRepository();

            var data = db.Courses;
            Thread.Sleep(1000);
            if (!string.IsNullOrEmpty(name) && name != "All") 
            {
                data = data.Where(q => q.Name.ToUpper().StartsWith(name.ToUpper())).ToList();
            }
            return PartialView(data);
        }
        
        public ActionResult FindCourseJson(string name)
        {

            CourseRepository db = new CourseRepository();

            var data = db.Courses;

            if (!string.IsNullOrEmpty(name) && name != "All")
            {
                data = data.Where(q => q.Name.ToUpper().StartsWith(name.ToUpper())).ToList();
            }
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}