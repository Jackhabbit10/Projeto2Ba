using Microsoft.AspNetCore.Mvc;

namespace Projeto2B
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
