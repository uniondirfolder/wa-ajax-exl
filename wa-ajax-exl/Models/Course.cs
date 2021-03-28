using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wa_ajax_exl.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }

    public class CourseRepository 
    {
        private  List<Course> _courses = new List<Course>();

        public  List<Course> Courses { get { return _courses; } }
        public CourseRepository()
        {
            _courses.Add(new Course { Id = 1, Name = "Java", Price = 100 });
            _courses.Add(new Course { Id = 2, Name = "JavaScript", Price = 120 });
            _courses.Add(new Course { Id = 3, Name = "C", Price = 130 });
            _courses.Add(new Course { Id = 4, Name = "C++", Price = 100 });
            _courses.Add(new Course { Id = 5, Name = "C#", Price = 200 });
        }
    }

}