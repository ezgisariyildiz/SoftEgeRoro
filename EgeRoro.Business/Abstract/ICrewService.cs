using EgeRoro.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Abstract
{
    public interface ICrewService
    {
        void CrewInsert(Crew c);
        void CrewUpdate(Crew c);
        void CrewDelete(Crew c);
        List<Crew> CrewGetList();
        //Crew CrewGetById(int id);
    }
}
