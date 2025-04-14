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
    public class GalleryManager : IGalleryService
    {
        IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void GalleryDelete(Gallery g)
        {
            _galleryDal.Delete(g);
        }

        public Gallery GalleryGetById(int id)
        {
            return _galleryDal.GetById(id);
        }

        public List<Gallery> GalleryGetList()
        {
            return _galleryDal.GetList();
        }

        public void GalleryInsert(Gallery g)
        {
            _galleryDal.Insert(g);
        }

        public void GalleryUpdate(Gallery g)
        {
            _galleryDal.Update(g);
        }
    }
}
