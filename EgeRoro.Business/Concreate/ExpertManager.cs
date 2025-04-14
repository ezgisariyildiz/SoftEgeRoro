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
    public class ExpertManager : IExpertService
    {
        IExpertDal _expertDal;

        public ExpertManager(IExpertDal expertDal)
        {
            _expertDal = expertDal;
        }

        public void ExpertDelete(Expert e)
        {
            _expertDal.Delete(e);
        }

        public List<Expert> ExpertGetList()
        {
            return _expertDal.GetList();
        }

        public void ExpertInsert(Expert e)
        {
            _expertDal.Insert(e);
        }

        public void ExpertUpdate(Expert e)
        {
            _expertDal.Update(e);
        }
    }
}
