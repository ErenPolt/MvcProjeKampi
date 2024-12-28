using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class ContentController : Controller
    {
        ContentManager cm = new ContentManager(new EfContentDal()); 
        public ActionResult Index()
        {
            return View();
        }
        //-------------------------------------------------------------------------------------------
        
        public ActionResult GetAllContent(string p="")//Tüm Yazıları listeleme
        {
            var values = cm.GetContentList(p);
            /*var values = from x in c.Contents select x;*/ //Contnet Tablosundan bir değer seç. Bu değeri karşılayan yapı x olsun..
            //if(!string.IsNullOrEmpty(p))//eğer ki p değeri boş değilse;
            //{
            //    values = values.Where(y=>y.ContentValue.Contains(p));//Tüm değerler gelsin ama x e seçilen değeri values'e aktar.
            //}
            //var values = c.Contents.ToList();
            return View(values.ToList());//Aksi durumda tüm değerleri listle
        }
        //-------------------------------------------------------------------------------------------
        public ActionResult ContentByHeading(int id)
        {
            var contentvalues = cm.GetListByHeadingId(id);
            return View(contentvalues);
        }
        //------------------------------------------------------------------------------------------------
    }
}