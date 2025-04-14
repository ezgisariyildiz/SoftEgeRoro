using EgeRoro.Business.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EgeRoro.UI.ViewComponents.Default
{
    public class _FleetMenu : ViewComponent
    {
        FleetManager fm = new FleetManager(new EfFleetDal());
        public IViewComponentResult Invoke()
        {
            var sonuc = fm.FleetGetList();
            return View(sonuc);
        }
    }
}

