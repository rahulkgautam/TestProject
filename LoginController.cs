using LoginLogout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LoginLogout.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Users users)
        {
            if (users.UserName == "Rahul123" && users.Password == "Rahul12345@")
            {
                FormsAuthentication.SetAuthCookie("Rahul123",false);
                return RedirectToAction("Index","Home");
            }
            return View("LoginPage");
        }
        public ActionResult Logout()
        {
             FormsAuthentication.SignOut();
            return RedirectToAction("LoginPage","Login");
        }

    }
}