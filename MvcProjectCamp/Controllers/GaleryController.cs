using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class GaleryController : Controller
    {
        // GET: Galeri
        ImageFileManager img = new ImageFileManager(new EfImageFileDal());
        public ActionResult Index()
        {
            var listImage = img.GetList();
            return View(listImage);
        }
    }
}