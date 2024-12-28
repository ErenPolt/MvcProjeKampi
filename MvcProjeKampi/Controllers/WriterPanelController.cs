using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using BusinessLayer.ValidationRules;
using FluentValidation.Results;

namespace MvcProjeKampi.Controllers
{
    public class WriterPanelController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterDal()); 
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        Context c = new Context();
        //-----------------------------------------------------------------
        [HttpGet]
        public ActionResult WriterProfile(int id=0)
        {
           string p = (string)Session["WriterMail"];
            id = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterId).FirstOrDefault();
            var writervalue = wm.GetByID(id);
            return View(writervalue);
        }
        [HttpPost]
        public ActionResult Writerprofile(Writer p)
        {
            WriterValidator writervalidator = new WriterValidator();
            ValidationResult results = writervalidator.Validate(p);
            if (results.IsValid)
            {
                wm.WriterUpdate(p);
                return RedirectToAction("AllHeading", "WriterPanel");
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
        //---------------------------------------------------------------
        //Yazarın başlıklarını Getirme;
        public ActionResult MyHeading(string p)
        {
           
            p = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == p).Select(y => y.WriterId).FirstOrDefault();
            var values = hm.GetListByWriter(writeridinfo);
            return View(values);
        }
        //----------------------------------------------------------------------------------------------------------------------
        //Tüm Başlıkları Görüntüleme;
        public ActionResult AllHeading(int p = 1)
        {
            var allheadings = hm.GetList().ToPagedList(p, 5);
            return View(allheadings);
        }
        //----------------------------------------------------------------------------------------------------------------------
        //Ekleme;

        [HttpGet]
        public ActionResult NewHeading()
        {
            //Kategori Tablosundan, Kategori isimlerini Listeleme
            List<SelectListItem> valuecategory = (from x in cm.GetCategoryList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();

            ViewBag.vlc = valuecategory;//Kategori İsmi
            return View();
        }

        [HttpPost]
        public ActionResult NewHeading(Heading p)
        {
            string writermailinfo = (string)Session["WriterMail"];
            var writeridinfo = c.Writers.Where(x => x.WriterMail == writermailinfo).Select(y => y.WriterId).FirstOrDefault();
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());//yeni girişlerde, bugünün tarihini otomatik ekle..
            p.WriterId = writeridinfo;
            p.HeadingStatus = true;
            hm.HeadigAdd(p);
            return RedirectToAction("MyHeading");
            
        }
        //----------------------------------------------------------------------------------------------------------------------------
        //Güncelleme İşlemi;

        [HttpGet]
        public ActionResult EditHeading(int id)
        {
            //Kategori Tablosundan, Kategori isimlerini Listeleme
            List<SelectListItem> valuecategory = (from x in cm.GetCategoryList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.CategoryName,
                                                      Value = x.CategoryId.ToString()
                                                  }).ToList();
            ViewBag.vlc = valuecategory;//Kategori İsmi
            var headingvalue = hm.GetById(id);
            return View(headingvalue);
        }

        [HttpPost]
        public ActionResult EditHeading(Heading p)
        {
            hm.HeadingUpdate(p);
            return RedirectToAction("MyHeading");
        }
        //----------------------------------------------------------------------------------------------------------------------------------
        //Silme işlemi;
        public ActionResult DeleteHeading(int id)//Silme işemi yerine aktif/Pasif işlemi yaptık..
        {
            var headingvalue = hm.GetById(id);
            headingvalue.HeadingStatus = false;
            hm.HeadingDelete(headingvalue);
            return RedirectToAction("MyHeading");
        }
    }
}