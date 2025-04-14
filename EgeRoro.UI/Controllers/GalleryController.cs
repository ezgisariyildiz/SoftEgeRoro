using System.Diagnostics;
using EgeRoro.Business.Concreate;
using EgeRoro.UI.Models;
using EgeRoroData.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace EgeRoro.UI.Controllers
{
    public class GalleryController : Controller
    {

        private readonly ILogger<GalleryController> _logger;
        private readonly GalleryManager _galleryManager;
        private readonly Context _context;

        public GalleryController(ILogger<GalleryController> logger, GalleryManager galleryManager, Context context)
        {
            _logger = logger;
            _galleryManager = galleryManager;
            _context = context;
        }

        public IActionResult Detail()
        {
            var allGallery = _context.Galleries.ToList(); // Tüm hizmetleri getir


            return View(allGallery);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
