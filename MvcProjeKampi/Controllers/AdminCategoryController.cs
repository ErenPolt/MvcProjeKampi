using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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
    public class AdminCategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        //--------------------------------------------------------------------------------
        [Authorize(Roles="A")]
        public ActionResult Index()//Listeleme işlemi
        {
            var categoryvalues = cm.GetCategoryList();
            return View(categoryvalues);
        }
        //---------------------------------------------------------------------------------
        //Kategorilere ait başlıkları gösterme;
        public ActionResult HeadingByCategory(int id)
        {
            var headings = headingManager.GetListByCategory(id);
            return View(headings);
        }

        //---------------------------------------------------------------------------------
        //Ekleme işlemi;
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            CategoryValidator categoryvalidator = new CategoryValidator();
            ValidationResult results= categoryvalidator.Validate(p);//Kategori sınıfındaki olan değerlere göre doğruluk kontrolünü yap..Yani paratmetreden gelen değerler; yani eklediklerimiz..

            if (results.IsValid)//Eğer sonuç geçerli ise;
            {
                cm.CategoryAdd(p);//Ekleme işlemi gerçekleştir ve;
                return RedirectToAction("Index");//ekledikten sonra listelemeye dön.
            }
            else//eğer şartlar karşılanmadıysa
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//Modelin Durumuna, hataları ekle(kategori adı veya açılamasının, hatasını göster..)..
                }
            }
            return View();
        }
        //-------------------------------------------------------------------------------------------
        //Silme İşlemi;
        public ActionResult DeleteCategory(int id)
        {
            var categoryvalue=cm.GetByID(id);
            cm.CategoryDelete(categoryvalue);
            return RedirectToAction("Index");
        }
        //-----------------------------------------------------------------------------------------------    
        //Güncelleme İşlemi;
        [HttpGet]
        public ActionResult EditCategory(int id)
        {
            var categoryvalue = cm.GetByID(id);
            return View(categoryvalue);
        }

        [HttpPost]
        public ActionResult EditCategory(Category p)
        {
            cm.CategoryUpdate(p);
            return RedirectToAction("Index");
        }
    }
}