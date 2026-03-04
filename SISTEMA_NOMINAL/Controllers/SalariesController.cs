using Microsoft.AspNetCore.Mvc;
using SistemaNomina.Models;

namespace SistemaNomina.Controllers
{
    public class SalariesController : Controller
    {
        private static List<Salary> salaries = new List<Salary>();

        public IActionResult Index()
        {
            return View(salaries);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Salary salary)
        {
            if (ModelState.IsValid)
            {
                salaries.Add(salary);
                return RedirectToAction(nameof(Index));
            }
            return View(salary);
        }
    }
}
