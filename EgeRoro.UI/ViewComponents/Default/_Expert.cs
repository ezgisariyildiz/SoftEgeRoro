using EgeRoro.Business.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EgeRoro.UI.ViewComponents.Default
{
    public class _Expert : ViewComponent
    {
        ExpertManager em = new ExpertManager(new EfExpertDal());

        public IViewComponentResult Invoke()
        {
            var sonuc = em.ExpertGetList();
            return View(sonuc);
        }
    }
}
