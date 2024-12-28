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
    public class HeadingManager : IHeadingService
    {
        IHeadingDal _headingDal;

        public HeadingManager(IHeadingDal headingDal)
        {
            _headingDal = headingDal;
        }

        public Heading GetById(int id)//Id'ye göre getirme..
        {
           return _headingDal.Get(x=>x.HeadingId==id);
        }

        public Dictionary<string, int> GetHeadingCountByCategory()
        {
            return _headingDal.List()
                        .GroupBy(h => h.Category.CategoryName)  // Başlıkları kategori adına göre grupla
                        .ToDictionary(g => g.Key, g => g.Count());  // Her kategoriye ait başlık sayısını al
        }

        public List<Heading> GetList()//Listeleme işlemi..
        {
            return _headingDal.List();
        }

        public List<Heading> GetListByCategory(int id)
        {
            return _headingDal.List(x => x.CategoryId == id);
        }

        public List<Heading> GetListByWriter(int id)
        {
           return _headingDal.List(x=>x.WriterId == id);
        }

        public void HeadigAdd(Heading heading)//Ekleme işlemi..
        {
            _headingDal.Insert(heading);
        }

        public void HeadingDelete(Heading heading)//Silme işlemi..
        {
        //    if (heading.HeadingStatus == true)
        //    {
        //        heading.HeadingStatus= false;
        //        _headingDal.Update(heading);
        //    }
        //    else if(heading.HeadingStatus==false)
        //    {
        //        heading.HeadingStatus = true;
        //        _headingDal.Update(heading);
        //    }
        //    //heading.HeadingStatus = false;
            _headingDal.Update(heading);
        }

        public void HeadingUpdate(Heading heading)//Güncelleme işlemi..
        {
            _headingDal.Update(heading);
        }
    }
}
