using CrupAppNew;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudAppAdo.Net.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            string query = "select * from UserList";
            var dt=new Connection();
            var model= dt.Select(query);
            return View("Index",model);
        }       
        public ActionResult Edit(int id)
        {
            string query = $"select * from UserList where Id={id}";
            var dt = new Connection();
            var model = dt.Select(query);
            return View("Edit", model);
        }
        public ActionResult Delete(int id)
        {
            string query = $"Delete UserList where Id={id}";
            var dt = new Connection();
            dt.Delete(query);
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Save()
        {            
            return View();
        }
        public ActionResult SaveDetails(FormCollection frm)
        {
            string query = $"Insert Into UserList values('{frm["UserName"]}','{frm["Email"]}','{frm["Password"]}')";
            var dt = new Connection();
            dt.Save(query);
            return RedirectToAction("Index","Home");
        }
        public ActionResult update(FormCollection frm)
        {
            string query = $"Update UserList set UserName='{frm["UserName"]}',Email='{frm["Email"]}',Password='{frm["Password"]}' where Id={frm["Id"]}";
            var dt = new Connection();
            dt.Save(query);
           return RedirectToAction("Index","Home");
        }
    }
}