using EgeRoro.Business.Concreate;
using EgeRoro.UI.Models;
using EgeRoroData.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EgeRoro.UI.Controllers
{
    public class FleetController : Controller
    {
        private readonly ILogger<FleetController> _logger;
        private readonly Context _context;
        FleetManager fm = new FleetManager(new EfFleetDal());

        public FleetController(ILogger<FleetController> logger, Context context, FleetManager fm)
        {
            _logger = logger;
            _context = context;
            this.fm = fm;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            var fleet = fm.FleetGetById(id); // Detay sayfası için
            

            return View(fleet);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
