using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CoreWebAppRazor.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreWebAppRazor.Pages
{
    public class LoginModel : PageModel
    {
        private readonly EComerceDbContext _context;

        public LoginModel(EComerceDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == UserName && u.Password == Password);

            if (user != null)
            {
                // Save user info in TempData or Session (for simplicity, TempData here)
                TempData["UserName"] = user.UserName;

                return RedirectToPage("/Dashboard");
            }
            else
            {
                ErrorMessage = "Invalid username or password.";
                return Page();
            }
        }
    }
}
