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
    public class FleetManager : IFleetService
    {
        IFleetDal _fleetDal;

        public FleetManager(IFleetDal fleetDal)
        {
            _fleetDal = fleetDal;
        }

        public void FleetDelete(Fleet f)
        {
            _fleetDal.Delete(f);
        }

        public Fleet FleetGetById(int id)
        {
            return _fleetDal.GetById(id);
        }

        public List<Fleet> FleetGetList()
        {
            return _fleetDal.GetList();
        }

        public void FleetInsert(Fleet f)
        {
            _fleetDal.Insert(f);
        }

        public void FleetUpdate(Fleet f)
        {
            _fleetDal.Update(f);
        }
    }
}
