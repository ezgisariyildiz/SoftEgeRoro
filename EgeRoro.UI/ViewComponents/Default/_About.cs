using EgeRoro.Business.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EgeRoro.UI.ViewComponents.Default
{
    public class _About : ViewComponent
    {
        AboutManager ab = new AboutManager(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var sonuc = ab.AboutGetList();
            return View(sonuc);
        }
    }
}
