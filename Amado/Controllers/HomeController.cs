using Amado.Data;
using Amado.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Amado.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
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
            var data = _context.Cart.Find(_context.User.Find(1).CartID);
            ViewBag.LINK = "Checkout.css";
            ViewBag.TITLE = "Checkout";
            return View(data);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}