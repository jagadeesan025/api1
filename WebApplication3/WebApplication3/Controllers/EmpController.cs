using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("Emp/GetEmpDetails")]
        public JsonResult GetEmpDetails()
        {
            List<employees> e = new List<employees>();
            e.Add(new employees { id = 1, name = "rahul", phoneno = 649718379 });
                e.Add(new employees { id = 1, name = "iniya", phoneno = 732456734 });
                e.Add(new employees { id = 1, name = "adhithi", phoneno = 808677288 });
                e.Add(new employees { id = 1, name = "santhiya", phoneno = 638086236 });
            return Json(new { empList = e });
        }
    }
}