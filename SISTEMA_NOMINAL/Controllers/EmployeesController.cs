using Microsoft.AspNetCore.Mvc;
using SistemaNomina.Models;

namespace SistemaNomina.Controllers
{
    public class EmployeesController : Controller
    {
        // Simulación de base de datos en memoria
        private static List<Employee> employees = new List<Employee>();

        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employees.Add(employee);
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }
    }
}
