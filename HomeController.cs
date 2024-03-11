using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (user.Age > 16)
            {
                return View("OrderForm", user);
            }
            else
            {
                // Redirect or show error message for underage users
                return RedirectToAction("Index"); // наприклад, перенаправленн€ на початкову стор≥нку
            }
        }


        [HttpPost]
        public IActionResult OrderProducts(User user, List<Product> products)
        {
            // Process the ordered products and show confirmation
            return View("OrderConfirmation", products);
        }
    }
}
