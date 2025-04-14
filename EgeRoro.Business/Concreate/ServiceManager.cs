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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void ServiceDelete(Service s)
        {
            _serviceDal.Delete(s);
        }

        public Service ServiceGetById(int id)
        {
            return _serviceDal.GetById(id);
        }

        public List<Service> ServiceGetList()
        {
            return _serviceDal.GetList();
        }

        public void ServiceInsert(Service s)
        {
            _serviceDal.Insert(s);
        }

        public void ServiceUpdate(Service s)
        {
            _serviceDal.Update(s);
        }
    }
}
