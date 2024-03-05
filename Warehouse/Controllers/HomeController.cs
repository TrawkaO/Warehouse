using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Warehouse.DAL.Interfaces;
using Warehouse.Domain.Entity;
using Warehouse.Models;

namespace Warehouse.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarRepository _carRepository;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var respons = await _carRepository.Select();
            return View();
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