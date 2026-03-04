using Microsoft.AspNetCore.Mvc;
using SistemaNomina.Models;

namespace SistemaNomina.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí iría la lógica para guardar el usuario en la base de datos
                return RedirectToAction("Index", "Employees");
            }
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Aquí iría la lógica para autenticar al usuario
                return RedirectToAction("Index", "Employees");
            }
            return View(model);
        }
    }
}
