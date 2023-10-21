using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MvcProjectCamp.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        LoginManager lm = new LoginManager(new EfLoginDal());
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Admin p)
        {
            var value = lm.GetList().FirstOrDefault(x => x.AdminPassword == p.AdminPassword && x.AdminUserName == p.AdminUserName);
            if (value != null)
            {
                FormsAuthentication.SetAuthCookie(value.AdminUserName, false);
                Session["AdminUserName"] = value.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            }
            else
            {
                return RedirectToAction("Index");
            }
                        
        }
        public ActionResult AuthIndex()
        {
            var authValues = lm.GetList();
            return View(authValues);
        }
    }
}