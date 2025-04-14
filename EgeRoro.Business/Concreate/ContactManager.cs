using EgeRoro.Business.Abstract;
using EgeRoro.Entity.Concreate;
using EgeRoroData.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Concreate
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactDelete(Contact c)
        {
            _contactDal.Delete(c);
        }

        public Contact ContactGetById(int id)
        {
            return _contactDal.GetById(id)
;        }

        public List<Contact> ContactGetList()
        {
            return _contactDal.GetList();
        }

        public void ContactInsert(Contact c)
        {
            _contactDal.Insert(c);
        }

        public void ContactUpdate(Contact c)
        {
            _contactDal.Update(c);
        }
    }
}
