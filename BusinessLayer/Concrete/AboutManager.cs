using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager: IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutAdd(About about)
        {
            _aboutDal.Insert(about);//Ekleme işlemi
        }

        public void AboutDelete(About about)
        {
            _aboutDal.Delete(about);//Silme işlemi
        }

        public void AboutUpdate(About about)
        {
           _aboutDal.Update(about);//Güncelle İşlemi
        }

        public About GetById(int id)
        {
           return _aboutDal.Get(x=>x.AboutId == id);//Id'yer  göre listeleme
        }

        public List<About> GetList()
        {
           return _aboutDal.List();//Listelme işlemi
        }
    }
}
