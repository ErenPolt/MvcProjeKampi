using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactService
    {//Yapılacak işlemler
        List<Contact> GetList();//İletişim Tablosunu Listeleme
        void ContactAdd(Contact contact);//İletişim Tablosu Ekleme
        Contact GetById(int id);//Id'ye göre getirme
        void ContactDelete(Contact contact);//İletişim Tablosu Silme
        void ContactUpdate(Contact contact);//İletişim Tablosu Güncelleme
    }
}
