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
        public string GetList(int pageSize)
        {
            string data = "{\"rows\": [ { \"No\": \"1400170322\", \"Name\": \"梁城月\", \"Gender\": \"男\"  }, {\"No\": \"1400170322\",\"Name\": \"梁城月\",\"Gender\": \"男\" }],\"results\": 2, \"hasError\": false, \"error\": \"\" }";
            return data;
        }
    }
}