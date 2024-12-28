using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context c = new Context();

        DbSet<T> _object;//_object; T Değerindeki tüm sınıfının değerlerini tutuyor

        public GenericRepository()//T değerine karşılık gelen sınıfı bulmak için; "ctor" işlemi..
        {
            _object= c.Set<T>();//Değer ataması
            //contexte bağlı olarak gelen t değeri atanmıştır.
        }

        public void Delete(T p)//Silme işlemi
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;//Silme komutu
            //_object.Remove(p);
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
            // "SingleOrDefault"--> Bir dizide veya listede , sadece bir değer geri  döndürmek için kullanılan entityfframewort metodudur..
            //Örn; Id'si 5 olan yazar dendiği zaman kullanılır..
        }

        public void Insert(T p)//Ekleme işlemi
        {
            var addedEntity = c.Entry(p);//Entry:Giriş
            addedEntity.State = EntityState.Added;//Ekleme komutu
            //_object.Add(p);
            c.SaveChanges();
        }

        public List<T> List()//Listeleme işlemi
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)//Şartlı listeleme işlemi
        {
            return _object.Where(filter).ToList();//filtreleme ne gönderirse onu listele..
        }

        public void Update(T p)//Güncelleme işlemi
        {
            var updatedEntity = c.Entry(p);
            updatedEntity.State = EntityState.Modified;//Güncelleme komutu
            c.SaveChanges();
        }
    }
}
