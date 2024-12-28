using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageService
    {//Yapılacak işlemler;
        List<Message> AdminMessageList();
        List<Message> AdminSendMessageList();
        List<Message> GetListInbox(string p);//Mesaj tablosu, Gelen mesaj listeleme işlemi
        List<Message> GetListSendbox(string p);//Mesaj tablosu, Gönderilen mesaj listeleme işlemi
        void MessageAdd(Message message);//Mesaj Tablosu Ekleme işlemi
        Message GetById(int id);//Id'ye göre getirme işlemi
        void MessageDelete(Message message);//Mesaj tablosu silme ilemi
        void MessageUpdate(Message message);//Mesaj Tanlosu Güncelleme işlemi
    }
}
