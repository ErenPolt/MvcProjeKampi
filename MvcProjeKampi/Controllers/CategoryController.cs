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
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryDal());
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCategoryList()//Listeleme işlemi
        {
            var values = cm.GetCategoryList();
            return View(values);
        }
        //---------------------------------------------------------------------------------
        
        [HttpGet]
        public ActionResult AddCategory()//Ekleme işlemi
        {
            return View();
        }
        
        
        
        
        [HttpPost]
        public ActionResult AddCategory(Category p)
        {
            //cm.CategoryAddBL(p);
            CategoryValidator categoryValidator = new CategoryValidator();
            ValidationResult results = categoryValidator.Validate(p);//Kategori sınıfındaki olan değerlere göre doğruluk kontrolünü yap..Yani paratmetreden gelen değerler; yani eklediklerimiz..
           
            if (results.IsValid)//Eğer sonuç geçerli ise;
            {
                cm.CategoryAdd(p);//Ekleme işlemi gerçekleştir ve;
                return RedirectToAction("GetCategoryList");//ekledikten sonra listelemeye dön.
            }

            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);//Modelin Durumuna, hataları ekle(kategori adı veya açılamasının, hatasını göster..)..
                }
            }
            return View();
        }
    }
}