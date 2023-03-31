using CryptoPriceApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CryptoPriceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                CryptoPriceInformation cryptoPriceInformation = new CryptoPriceInformation();
                await cryptoPriceInformation.CryptoPrice();
                _logger.LogInformation($"Success Response!");
                return View("Index", cryptoPriceInformation);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error message: {ex.Message}");
                return View("Index");
            }
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