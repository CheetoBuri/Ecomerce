using ASPCoreWebAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ASPCoreWebAppMVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly ECommerceDbContext _context;

        public AccountController(ECommerceDbContext context)
        {
            _context = context;
        }

        // GET: /Account/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: /Account/Register
        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }

        // GET: /Account/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public IActionResult Login(string userName, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == userName && u.Password == password);

            if (user != null)
            {
                // Set TempData flag to simulate login status
                TempData["IsLoggedIn"] = true;
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Message = "Invalid username or password.";
            return View();
        }
    }
}
