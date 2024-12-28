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
    public class HeadingController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        WriterManager wm = new WriterManager(new EfWriterDal());
        //-----------------------------------------------------------------------------------------
        //Listeleme İşlemi;
        public ActionResult Index()
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }

        public ActionResult HeadingReport()//Raporlama
        {
            var headingvalues = hm.GetList();
            return View(headingvalues);
        }
        //---------------------------------------------------------------------------------------
        //Ekleme İŞlemi;
        
        [HttpGet]
        public ActionResult HeadingAdd()
        {
            //Kategori Tablosundan, Kategori isimlerini Listeleme
            List<SelectListItem> valuecategory = (from x in cm.GetCategoryList()
                                                  select new SelectListItem
                                                  {
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryId.ToString()
                                                  }).ToList();

            //Yazar Tablosundan, Yazar İsimlerini Listeleme;
            List<SelectListItem> valuewriter = (from x in wm.GetList()
                                                select new SelectListItem
                                                {
                                                    Text=x.WriterName +" "+ x.WriterSurName,
                                                    Value=x.WriterId.ToString()
                                                }).ToList();

            ViewBag.vlw = valuewriter;//Yazar ismi
            ViewBag.vlc = valuecategory;//Kategori İsmi
            return View();
        }

        [HttpPost]
        public ActionResult HeadingAdd(Heading p)
        {
            p.HeadingDate = DateTime.Parse(DateTime.Now.ToShortDateString());//yeni girişlerde, bugünün tarihini otomatik ekle..
            hm.HeadigAdd(p);
            return RedirectToAction("Index");
        }
        //-----------------------------------------------------------------------------------------------------------------------
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
            return RedirectToAction("Index");
        }
        //------------------------------------------------------------------------------------------------------------------------
        public ActionResult DeleteHeading(int id)//Silme işemi yerine aktif/Pasif işlemi yaptık..
        {
            var headingvalue = hm.GetById(id);

            if (headingvalue.HeadingStatus == false)
            {
                headingvalue.HeadingStatus = true;
            }
            else
            {
                headingvalue.HeadingStatus = false;
            }

            hm.HeadingDelete(headingvalue);
            return RedirectToAction("Index");
        }
    }
}