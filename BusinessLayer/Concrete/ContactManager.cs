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
    public class ContactManager: IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactAdd(Contact contact)
        {
           _contactDal.Insert(contact);//Ekleme işlemi
        }

        public void ContactDelete(Contact contact)
        {
           _contactDal.Delete(contact);//Silme işlemi
        }

        public void ContactUpdate(Contact contact)
        {
           _contactDal.Update(contact);//Güncelleme işlemi
        }

        public Contact GetById(int id)
        {
            return _contactDal.Get(x => x.ContactId == id);//Id'ye göre getirme
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();//Listeleme işlemi
        }
    }
}
