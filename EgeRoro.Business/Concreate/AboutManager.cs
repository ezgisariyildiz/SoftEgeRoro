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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void AboutDelete(About a)
        {
            _aboutDal.Delete(a);
        }

        public About AboutGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> AboutGetList()
        {
            return _aboutDal.GetList();
        }

        public void AboutInsert(About a)
        {
            _aboutDal.Insert(a);
        }

        public void AboutUpdate(About a)
        {
            _aboutDal.Update(a);
        }
    }
}
