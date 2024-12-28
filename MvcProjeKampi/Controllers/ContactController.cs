using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContactController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDAl());
        ContactManager cm = new ContactManager(new EfContactDal());
        ContactValidator cv = new ContactValidator();
        //------------------------------------------------------------------------
        //Listeleme işlemi;
        public ActionResult Index()
        {
            var contactvalues = cm.GetList();
            return View(contactvalues);
        }
        //--------------------------------------------------------------------------
        //Mesaj Detayları;

        public ActionResult GetContactDetails(int id)
        {
            var contactvalues = cm.GetById(id);  
            return View(contactvalues);
        }
        //--------------------------------------------------------------------------
        //Seçenekler Tablosu Partial' taşııma
        public PartialViewResult MessageListMenu()
        {
            //ViewBag.messageCount = cm.GetList().Count;
            //ViewBag.inboxMessageCount = mm.GetListInbox(p).Count;
            //ViewBag.sendMessageCount = mm.GetListSendbox(p).Count;
            //ViewBag.trashMessages = mm.GetTrashMessages(p).Count();
            //ViewBag.draftMessageCount = mm.GetDraftMessages(p).Count();

            return PartialView();
        }
    }
}