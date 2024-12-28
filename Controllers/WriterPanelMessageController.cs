using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelMessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDAl());
        MessageValidator messagevalidator = new MessageValidator();
        Context c = new Context();
        //----------------------------------------------------------------------------------
        public ActionResult Inbox()//Yazara gelen mesaj
        {
            string p = (string)Session["WriterMail"];
            var messagelist = mm.GetListInbox(p);
            return View(messagelist);
        }
        //-------------------------------------------------------------------------------------
        //Yazara ait Partial;
        public PartialViewResult MessageListMenu()
        {
            return PartialView();
        }
        //--------------------------------------------------------------------------------------
        //Yazarın Gönderdiği mesajlar;
        public ActionResult Sendbox()
        {
            string p = (string)Session["WriterMail"];
            var messagelist = mm.GetListSendbox(p);
            return View(messagelist);
        }
        //----------------------------------------------------------------------------------------
        //Gelen KutusuMesaj Detayları;
        public ActionResult GetInboxMessageDetails(int id)
        {
            var values = mm.GetById(id);
            return View(values);
        }
        //------------------------------------------------------------------------------------------
        //Gönderilen KutusuMesaj Detayları;
        public ActionResult GetSendMessageDetails(int id)
        {
            var values = mm.GetById(id);
            return View(values);
        }
        //------------------------------------------------------------------------------------------
        //Mesaj ekleme;
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {
            string sender = (string)Session["WriterMail"];
            ValidationResult results = messagevalidator.Validate(p);
            if (results.IsValid)
            {
                p.Sender = sender;
                p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                mm.MessageAdd(p);
                return RedirectToAction("Sendbox");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
            //-------------------------------------------------------------------------------------------
        }
    }
}