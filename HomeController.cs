using LoginLogout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginLogout.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Save(Employee details)
        {

            return Json(true);
        }
        public ActionResult GetEmployee(Employee details)
        {
            var data = new Employee()
            {
                Desibility = true,
                FirstName="Rahul",
                LastName="Kumar"
            };
            return Json(data);
        }
    }
}