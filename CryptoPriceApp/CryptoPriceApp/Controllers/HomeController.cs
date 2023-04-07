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
        CryptoPriceInformation cryptoPriceInformation = new CryptoPriceInformation();
        public async Task<IActionResult> Index()
        {
            try
            {
                await cryptoPriceInformation.CryptoPrice();
                _logger.LogInformation($"Success Response!\n" +
                    $"\tBitcoin:\n" +
                    $"\t\tPrise: {cryptoPriceInformation.bitcoinPrice} $\n" +
                    $"\t\tChange: {cryptoPriceInformation.bitcoinChange} %\n" +
                    $"\tEthereum:\n" +
                    $"\t\tPrise: {cryptoPriceInformation.ethereumPrice} $\n" +
                    $"\t\tChange: {cryptoPriceInformation.ethereumChange} %\n" +
                    $"\tCardano:\n" +
                    $"\t\tPrise: {cryptoPriceInformation.cardanoPrice} $\n" +
                    $"\t\tChange: {cryptoPriceInformation.cardanoChange} %\n" +
                    $"\tDogecoin:\n" +
                    $"\t\tPrise: {cryptoPriceInformation.dogecoinPrice} $\n" +
                    $"\t\tChange: {cryptoPriceInformation.dogecoinChange} %\n" +
                    $"\tLitecoin:\n" +
                    $"\t\tPrise: {cryptoPriceInformation.litecoinPrice} $\n" +
                    $"\t\tChange: {cryptoPriceInformation.litecoinChange} %\n" +
                    $"\tTether:\n" +
                    $"\t\tPrise: {cryptoPriceInformation.tetherPrice} $\n" +
                    $"\t\tChange: {cryptoPriceInformation.tetherChange} %\n" +
                    $"\tSolana:\n" +
                    $"\t\tPrise: {cryptoPriceInformation.solanaPrice} $\n" +
                    $"\t\tChange: {cryptoPriceInformation.solanaChange} %\n");
                _logger.LogInformation($"Your URL: {cryptoPriceInformation.GetURL()}");
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