using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAdminService
    {
        List<Admin> GetList();//Admin tablosu listeleme
        void AdminAdd(Admin admin);//Admintablosu ekleme
        Admin GetByID(int id);//İd'ye göre bulma işlemi
        void AdminDelete(Admin admin);//Silme işlemi için
        void AdminUpdate(Admin admin);//Güncelleme işlemi
    }
}
