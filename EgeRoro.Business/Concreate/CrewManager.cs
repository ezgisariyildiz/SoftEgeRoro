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
    public class CrewManager : ICrewService
    {
        ICrewDal _crewDal;

        public CrewManager(ICrewDal crewDal)
        {
            _crewDal = crewDal;
        }

        public void CrewDelete(Crew c)
        {
            _crewDal.Delete(c);
        }

        public List<Crew> CrewGetList()
        {
            return _crewDal.GetList();
        }

        public void CrewInsert(Crew c)
        {
            _crewDal.Insert(c);
        }

        public void CrewUpdate(Crew c)
        {
            _crewDal.Update(c);
        }
    }
}
