using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetCategoryList();//Kategori tablosu listeleme
        void CategoryAdd(Category category);//Kategori tablosu ekleme
        Category GetByID(int id);//İd'ye göre bulma işlemi
        void CategoryDelete(Category category);//Silme işlemi için
        void CategoryUpdate(Category category);//Güncelleme işlemi
    }
}
