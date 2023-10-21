using BusinessLayer.Concrete;
using BusinessLayer.Concrete.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjectCamp.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        ContactManager cm = new ContactManager(new EfContactDal());
        MessageManager  messageManager = new MessageManager(new EfMessageDal());

        ContactValidator cv = new ContactValidator();
        public ActionResult Index()
        {
            var contactValue = cm.GetList();
           
            return View(contactValue);
        }
        public PartialViewResult ContactPartial()
        {
            var totalReciverMail = messageManager.GetListInbox().Count();
            ViewBag.totalReciverMail = totalReciverMail;

            var totalSenderMail = messageManager.GetListSenbox().Count();
            ViewBag.totalSenderMail = totalSenderMail;

            var totalContactMessage = cm.GetList().Count();
            ViewBag.totalContactMessage = totalContactMessage;
            return PartialView();
        }

        [HttpGet]
        public ActionResult GetContactDetails(int id)
        {
            var contactValues = cm.GetByID(id);
            return View(contactValues);
        }

    }
}