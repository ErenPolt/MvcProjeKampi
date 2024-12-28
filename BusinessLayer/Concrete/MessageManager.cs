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
    public class MessageManager: IMessageService
    {
        IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public List<Message> AdminMessageList()
        {
            return _messageDal.List(x => x.Receiver == "admin@gmail.com");
        }

        public List<Message> AdminSendMessageList()
        {
            return _messageDal.List(x => x.Sender == "admin@gmail.com");
        }

        public Message GetById(int id)
        {
            return _messageDal.Get(x => x.MessageId == id);//Id'ye göre Getirme
        }

        public List<Message> GetListInbox(string p)//Gelen mesaj listeleme
        {
            return _messageDal.List(x => x.Receiver == p);
        }
        public List<Message> GetListSendbox(string p)//Gönderilen mesaj listeleme
        {
            return _messageDal.List(x => x.Sender == p);
        }

        public void MessageAdd(Message message)
        {
            _messageDal.Insert(message);//ekleme işlemi
        }

        public void MessageDelete(Message message)
        {
            throw new NotImplementedException();
        }

        public void MessageUpdate(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
