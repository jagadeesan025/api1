using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Student/GetStudentDetails")]
        public JsonResult GetStudentDetails()
        {
            return Json(new {name = "test",age = 20 });
       }

        [HttpGet("Student/GetStudentDetails1")]
        public JsonResult GetStudentDetails1()
        {
            List<Student> s = new List<Student>();
            s.Add(new Student { id = 1, name = "Test",age = 20 });
            s.Add(new Student { id = 1, name = "Test", age = 20 });
            s.Add(new Student { id = 1, name = "Test", age = 20 });
            s.Add(new Student { id = 1, name = "Test", age = 20 });
            return Json(new { studList = s});
        }
    }


}