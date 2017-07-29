using Application.Unit.Dto;
using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult GetList()
        {
            var list = new ListDto<Student>();
            var l = new List<Student>();
            l.Add(new Student { No = "1400170322", Name = "梁城月", Gender = "男" });
            l.Add(new Student { No = "1400170322", Name = "lcy", Gender = "男" });
            list.rows = l;
            list.results = 2;
            return Json(list, JsonRequestBehavior.AllowGet);
        }
    }
}