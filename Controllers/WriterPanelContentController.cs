using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal());
        Context c = new Context();
        //-------------------------------------------------------------------------------
        //Yazara ait yazıları listeleme;
        public ActionResult MyContent(string p)
        {
           
            p = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x=>x.WriterMail== p).Select(y=>y.WriterId).FirstOrDefault();
            var values = cm.GetListByWriter(writeridinfo);
            return View(values);
        }
        //-----------------------------------------------------------------------------
        //Başlıklara Yazı Yazma;
        [HttpGet]
        public ActionResult AddContent(int id)
        {
            ViewBag.d = id;
            return View();
        }

        [HttpPost]
        public ActionResult AddContent(Content p)
        {
           string  mail = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == mail).Select(y => y.WriterId).FirstOrDefault();
            p.ContentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.WriterId = writeridinfo;
            p.ContentStatus = true;
            cm.ContentAdd(p);
            return RedirectToAction("MyContent");
        }
        //-----------------------------------------------------------------------------------
        
    }
}