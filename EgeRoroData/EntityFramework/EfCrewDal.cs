using EgeRoro.Entity.Concreate;
using EgeRoroData.Abstract;
using EgeRoroData.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoroData.EntityFramework
{
    public class EfCrewDal : GenericRepository<Crew>, ICrewDal
    {
    }
}
