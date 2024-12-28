using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AdminManager: IAdminService
    {
        IAdminDal _adminDal;

        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public void AdminAdd(Admin admin)//Ekleme
        {
            _adminDal.Insert(admin);
        }

        public void AdminDelete(Admin admin)//Silme işlemi
        {
            _adminDal.Delete(admin);
        }

        public void AdminUpdate(Admin admin)//Güncelleme 
        {
            _adminDal.Update(admin);
        }

        public Admin GetByID(int id)
        {
            return _adminDal.Get(x => x.AdminId == id);
        }

        public List<Admin> GetList()//Listeleme işlemi
        {
            return _adminDal.List();
        }
    }
}
