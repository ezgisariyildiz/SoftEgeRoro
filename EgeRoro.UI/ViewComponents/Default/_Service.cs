using EgeRoro.Business.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EgeRoro.UI.ViewComponents.Default
{
    public class _Service : ViewComponent
    {
        ServiceManager sm = new ServiceManager(new EfServiceDal());
        public IViewComponentResult Invoke()
        {
            var sonuc = sm.ServiceGetList();
            return View(sonuc);
        }
    }
}
