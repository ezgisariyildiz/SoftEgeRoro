using EgeRoro.Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgeRoro.Business.Abstract
{
    public interface IGalleryService
    {
        void GalleryInsert(Gallery g);
        void GalleryUpdate(Gallery g);
        void GalleryDelete(Gallery g);
        List<Gallery> GalleryGetList();
        Gallery GalleryGetById(int id);
    }
}
