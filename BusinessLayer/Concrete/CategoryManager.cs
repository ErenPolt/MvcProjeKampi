using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void CategoryAdd(Category category)//Ekleme işlemi
        {
            _categoryDal.Insert(category);
        }

        public void CategoryDelete(Category category)//Silme işlemi
        {
          _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)//Güncelleme işlemi
        {
            _categoryDal.Update(category);
        }

        public Category GetByID(int id)
        {
            return _categoryDal.Get(x=>x.CategoryId == id);
        }

        public List<Category> GetCategoryList()//listeleme işlemi
        {
            return _categoryDal.List();
        }
    }
}

