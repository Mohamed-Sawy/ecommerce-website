using Amado.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Amado.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

  
        public IActionResult Index()
        {
            ViewBag.LINK = "Index.css";
            ViewBag.TITLE = "Home";
            return View();
        }
        public IActionResult Shop()
        {
            ViewBag.LINK = "Shop.css";
            ViewBag.TITLE = "Shop";
            return View();
        }  
        public IActionResult Cart()
        {
            ViewBag.LINK = "Cart.css";
            ViewBag.TITLE = "Cart";
            return View();
        }   
        public IActionResult Checkout()
        {
            ViewBag.LINK = "Checkout.css";
            ViewBag.TITLE = "Checkout";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}