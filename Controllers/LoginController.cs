using Microsoft.AspNetCore.Mvc;

namespace Online_Library_Management_System.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult userLogin()
        {
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}
