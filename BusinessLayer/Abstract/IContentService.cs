using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetContentList(string p);//Content Tablosu Listeleme
        List<Content> GetListByHeadingId(int id);//Id'ye göre bütün listeyi döndürür.
        List<Content> GetListByWriter(int id);
        void ContentAdd(Content content);//Content Tablosu Ekleme işlemi
        Content GetById(int id);//Id'ye göre bulma işlemi.Tek bir değer döndürür
        void ContentDelete(Content content);//Silme işlemi
        void ContentUpdate(Content content);//Güncelleme işlemi
        Dictionary<string, int> GetContentCountByHeading();
    }
}
