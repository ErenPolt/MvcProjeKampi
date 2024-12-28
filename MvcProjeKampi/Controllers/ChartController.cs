using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MvcProjeKampi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        ContentManager cm = new ContentManager(new EfContentDal());
        Context c = new Context();
        public ActionResult Index()
        {
            ViewBag.totalCategory = c.Categories.Count();//Toplam Kategori
            ViewBag.totalHeading = c.Headings.Count();//Toplam Başlık
            ViewBag.totalContent = c.Contents.Count();//Toplam Yazı
            ViewBag.totalWriter = c.Writers.Count();//Toplam Yazar
            ViewBag.maxCategory = c.Headings.GroupBy(h => h.Category.CategoryName).OrderByDescending(g => g.Count()).Select(g => g.Key).FirstOrDefault();
            ViewBag.status = c.Categories.Where(x => x.CategoryStatus == true).Count() - c.Categories.Where(x => x.CategoryStatus == false).Count();
            return View();
        }
        public JsonResult HeadingCountByCategory()
        {
            var data = hm.GetHeadingCountByCategory();
            return Json(data, JsonRequestBehavior.AllowGet);  // Veriyi JSON olarak döner
        }
        public JsonResult ContentCountByHeading()
        {
            var headingContentCounts = cm.GetContentCountByHeading();
            return Json(headingContentCounts, JsonRequestBehavior.AllowGet);
        }

        //public ActionResult CategoryChart()
        //{
        //    return Json(BlogList(), JsonRequestBehavior.AllowGet);
        //}

        //public List<CategoryClass> BlogList()
        //{
        //    List<CategoryClass> ct = new List<CategoryClass>();
        //    ct.Add(new CategoryClass()
        //    {
        //        CategoryName = "Yazılım",
        //        CategoryCount = 8
        //    });
        //    ct.Add(new CategoryClass()
        //    {
        //        CategoryName = "Seyahat",
        //        CategoryCount = 4
        //    });
        //    ct.Add(new CategoryClass()
        //    {
        //        CategoryName = "Teknoloji",
        //        CategoryCount = 7
        //    });
        //    ct.Add(new CategoryClass()
        //    {
        //        CategoryName = "Spor",
        //        CategoryCount = 1
        //    });
        //    return ct;
        //}
    }
}