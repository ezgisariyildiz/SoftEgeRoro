using EgeRoro.Business.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EgeRoro.UI.ViewComponents.Default
{
    public class _Crew : ViewComponent
    {
        CrewManager cm = new CrewManager(new EfCrewDal());
        public IViewComponentResult Invoke()
        {
            var value = cm.CrewGetList();
            return View(value);
        }
    }
}
