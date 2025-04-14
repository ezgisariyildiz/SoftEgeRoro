using EgeRoro.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Abstract
{
    public interface IFleetService
    {
        void FleetInsert(Fleet f);
        void FleetUpdate(Fleet f);
        void FleetDelete(Fleet f);
        List<Fleet> FleetGetList();
        Fleet FleetGetById(int id);
    }
}
