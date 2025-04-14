using EgeRoro.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Abstract
{
    public interface IServiceService
    {
        void ServiceInsert(Service s);
        void ServiceUpdate(Service s);
        void ServiceDelete(Service s);
        List<Service> ServiceGetList();
        Service ServiceGetById(int id);
    }
}
