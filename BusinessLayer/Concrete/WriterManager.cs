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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public Writer GetByID(int id)
        {
          return _writerDal.Get(x=>x.WriterId == id);//Id'ye göre çağırma
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();//Listele
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);//Ekleme 
        }

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);//Silme
        }

        public void WriterUpdate(Writer writer)
        {
           _writerDal.Update(writer);//Güncelleme
        }
    }
}
