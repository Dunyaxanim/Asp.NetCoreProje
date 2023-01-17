using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concreate
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;
        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelet(Contact t)
        {
            throw new NotImplementedException();
        }

        public Contact TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public int TGetCount()
        {
            
            return _contactDal.GetCount();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }
}
