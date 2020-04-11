using Microsoft.AspNetCore.Mvc;

namespace BenjaminCamacho.Controllers
{
    
        public class AccountController : Controller
        {

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        }
}
