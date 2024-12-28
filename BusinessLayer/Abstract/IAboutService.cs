using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutService
    {
        List<About> GetList();//Hakkımda Tablosunu Listeleme
        void AboutAdd(About about);//Hakkımda Tablosu Ekleme
        About GetById(int id);
        void AboutDelete(About about);//Hakkımda Tablosu Silme
        void AboutUpdate(About about);//Hakkımda Tablosu Güncelleme
    }
}
