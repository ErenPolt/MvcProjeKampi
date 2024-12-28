using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterService
    {
        List<Writer> GetList();//Listeleme metodu
        void WriterAdd(Writer writer);//Ekleme metodu
        void WriterDelete(Writer writer);//Silme metodu
        void WriterUpdate(Writer writer);//Güncelleme metodu
        Writer GetByID(int id);//Id'ye göre getirme..
    }
}
