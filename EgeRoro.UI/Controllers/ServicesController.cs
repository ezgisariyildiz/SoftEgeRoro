using EgeRoro.Business.Concreate;
using EgeRoro.UI.Models;
using EgeRoroData.Concreate;
using EgeRoroData.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EgeRoro.UI.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ILogger<ServicesController> _logger;
        private readonly ServiceManager _serviceManager;
        private readonly Context _context;

        public ServicesController(ILogger<ServicesController> logger, ServiceManager serviceManager, Context context)
        {
            _logger = logger;
            _serviceManager = serviceManager;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            var service = _context.Services.FirstOrDefault(s => s.Id == id); // Detay sayfası için
            var allServices = _context.Services.ToList(); // Tüm hizmetleri getir

            var model = new ServiceDetailViewModel
            {
                SelectedService = service,
                AllServices = allServices
            };

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
