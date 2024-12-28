using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{//Repositories klosörde;  crud işlemleri gerçekleşmesi için apılacak ifadeleri burada tutacak.
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();
        DbSet<Category> _object;//_object kategori sınıfının değerlerini tutuyor
        public void Delete(Category p)//Silme
        {
           _object.Remove(p);
            c.SaveChanges();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Category p)//Ekleme
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Category> List()//Listeleme işlemi
        {
           return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)//Güncelleme
        {
            c.SaveChanges();
        }
    }
}

//ToList: Listeleme için
//Add: Ekleme için
//Remove: Silme için
//Find: Bulma işlemi