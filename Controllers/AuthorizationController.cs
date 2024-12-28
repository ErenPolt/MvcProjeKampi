using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class AuthorizationController : Controller
    {
        AdminManager adminManager = new AdminManager(new EfAdminDal());
        //-----------------------------------------------------------------------------------------
        public ActionResult Index()//Listeleme
        {
            var adminvalues = adminManager.GetList();
            return View(adminvalues);
        }
        //----------------------------------------------------------------------------------------
        //Ekleme işlemi
        [HttpGet]
        public ActionResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdmin(Admin p)
        {
            adminManager.AdminAdd(p);
            return RedirectToAction("Index");
        }
        //----------------------------------------------------------------------------------------
        //Güncelleme işlemi
        [HttpGet]
        public ActionResult EditAdmin(int id)
        {
            var adminvalue = adminManager.GetByID(id);
            return View(adminvalue);
        }

        [HttpPost]
        public ActionResult EditAdmin(Admin p)
        {
            adminManager.AdminUpdate(p);
            return RedirectToAction("Index");
        }
        //-------------------------------------------------------------------------------------
        //Silme işlemi
        public ActionResult DeleteAdmin(int id)
        {
            var adminvalue = adminManager.GetByID(id);
            adminManager.AdminDelete(adminvalue);
            return RedirectToAction("Index");
        }
    }
}