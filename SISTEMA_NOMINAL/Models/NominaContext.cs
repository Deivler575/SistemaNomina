using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SistemaNomina.Models
{
    public class NominaContext : DbContext
    {
        public NominaContext(DbContextOptions<NominaContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
