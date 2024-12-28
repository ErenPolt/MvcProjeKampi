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
    public class MessageController : Controller
    {
        MessageManager mm = new MessageManager(new EfMessageDAl());
        MessageValidator messagevalidator = new MessageValidator();
        //----------------------------------------------------------------------------------
        //Gelen mesajlar;
        [Authorize]
        public ActionResult Inbox()
        {
            var messagelist = mm.AdminMessageList();
            return View(messagelist);
        }
        //-------------------------------------------------------------------------------------
        //Gönderilen mesajlar;
        public ActionResult Sendbox()
        {
            var messagelist = mm.AdminSendMessageList();
            return View(messagelist);
        }
        //--------------------------------------------------------------------------------------
        //Mesaj ekleme;
        [HttpGet]
        public ActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewMessage(Message p)
        {

            ValidationResult results = messagevalidator.Validate(p);
            if (results.IsValid)
            {
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
        }
        //-----------------------------------------------------------------------------------------
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
        
    }
}