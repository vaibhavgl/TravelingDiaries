using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TravelingDiaries.Models;

namespace TravelingDiaries.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlaceRepository placeRepository;

        public HomeController(ILogger<HomeController> logger, IPlaceRepository placeRepository)
        {
            _logger = logger;
            this.placeRepository = placeRepository;
        }

        public IActionResult Index()
        {
            var places = placeRepository.GetAllPlaces();
            return View(places);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}