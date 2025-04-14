using EgeRoro.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Abstract
{
    public interface IExpertService
    {
        void ExpertInsert(Expert e);
        void ExpertUpdate(Expert e);
        void ExpertDelete(Expert e);
        List<Expert> ExpertGetList();
        //Expert ExpertGetById(int id);
    }
}
