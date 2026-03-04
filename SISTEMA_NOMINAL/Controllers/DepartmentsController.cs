using Microsoft.AspNetCore.Mvc;
using SistemaNomina.Models;

namespace SistemaNomina.Controllers
{
    public class DepartmentsController : Controller
    {
        private static List<Department> departments = new List<Department>();

        public IActionResult Index()
        {
            return View(departments);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                departments.Add(department);
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }
    }
}
