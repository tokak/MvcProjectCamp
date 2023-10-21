using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class istatistikController : Controller
    {
        // GET: istatistik
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        Context context = new Context();
        public ActionResult Index()
        {
            var totalCategory = cm.GetList();
            ViewBag.totalCategory = totalCategory.Count();
            var totalHeading = hm.GetList(x => x.CategoryID == 11).Count();
            ViewBag.totalHeading = totalHeading;
            var atotalWriter = wm.GetList(x => x.WriterName.Contains("a")).Count();
            ViewBag.atotalWriter = atotalWriter;
            var totalHeadingtoCategory = hm.GetList().Max(x => x.Category.CategoryName);
            ViewBag.totalHeadingtoCategory = totalHeadingtoCategory;
            var categoryTrue = cm.GetList().Where(x => x.CategoryStatus == true).Count();
            var categoryFalse = cm.GetList().Where(x => x.CategoryStatus == false).Count();
            var fark = Math.Abs(categoryFalse - categoryTrue);
            ViewBag.fark = fark; 
            return View();
        }
    }
}