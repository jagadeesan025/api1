using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Defult/GetemployeeDetials")]

        public JsonResult GetemployeeDetials()
        {
            return Json(new { name = "karthik", age = 20 });

        }
        [HttpGet("Defult/GetemployeeDetials1")]
        public JsonResult GetemployeeDetials1()
        {

            List<employee> e = new List<employee>();

            e.Add(new employee { id = 1, name = "karthik", school = "e" });
            e.Add(new employee { id = 1, name = "nihana", school = "r" });
            e.Add(new employee { id = 1, name = "sunder", school = "r" });
            e.Add(new employee { id = 1, name = "dharun", school = "f" });
            return Json(new { employee = e });

        }

    }
}
