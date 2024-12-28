using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>//T buradaki tüm entitylere karşılık gelir. T sayesinde hangi sınıfla işşlem yapmak istersek yaparız..
    { //Sınıflara rehberlik eden yapılara; Interfaace denir..

        //Crud operasyonlarını metot olarak tanımla;
        //Type Name();
        List<T> List();//Listeleme İŞlemi

        void Insert(T p);//Ekleme işlemi

        T Get(Expression<Func<T, bool>> filter);//ID'ye göre silme işlemi için;

        void Delete(T p);//Silme işlemi

        void Update(T p);//Güncelleme işlemi

        List<T> List(Expression<Func<T, bool>> filter);//Şartlı listeleme işlemi yapıyor.
        //örn: İsmi Ali olanları bul gibi..
    }
}
