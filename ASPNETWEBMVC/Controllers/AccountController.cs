using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETWEBMVC.ViewModels;

namespace ASPNETWEBMVC.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            ViewData["ControllerName"] = "Account";  // Set the current controller name
            ViewData["ActionName"] = "Login";  // Set the current action name
            return View();
        }

        // GET: Account/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Your login logic goes here, e.g., validate credentials
                return RedirectToAction("Index", "Home");
            }

            // If we reach this point, there was an error in the login, so we return the same view
            return View(model);
        }
    }
}