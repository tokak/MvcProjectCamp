using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class SkillController : Controller
    {
        // GET: Skill
        Context c = new Context();
        public ActionResult Index()
        {
            var skillResult = c.Skills.ToList();
            return View(skillResult);
        }
    }
}