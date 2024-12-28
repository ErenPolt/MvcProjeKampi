using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();//Başlık Tablosunu Listeleme
        List<Heading> GetListByCategory(int id);//Kategorilere ait başlıklar
        List<Heading> GetListByWriter(int id);//Yazarın kendi başlılarını listelemesi
        void HeadigAdd(Heading heading);//Başlık Tablosu Ekleme
        Heading GetById(int id);
        void HeadingDelete(Heading heading);//Başlık Tablosu Silme
        void HeadingUpdate(Heading heading);//Başlık Tablosu Güncelleme
        Dictionary<string, int> GetHeadingCountByCategory();
    }
}
