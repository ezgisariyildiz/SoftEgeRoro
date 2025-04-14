using EgeRoro.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Abstract
{
    public interface IContactService
    {
        void ContactInsert(Contact c);
        void ContactUpdate(Contact c);
        void ContactDelete(Contact c);
        List<Contact> ContactGetList();
        Contact ContactGetById(int id);
    }
}
