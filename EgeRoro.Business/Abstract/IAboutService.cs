using EgeRoro.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Abstract
{
    public interface IAboutService
    {
        void AboutInsert(About a);
        void AboutUpdate(About a);
        void AboutDelete(About a);
        List<About> AboutGetList();
        About AboutGetById(int id);
    }
}
