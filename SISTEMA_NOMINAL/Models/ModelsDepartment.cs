using System.ComponentModel.DataAnnotations;

namespace SistemaNomina.Models
{
    public class Department
    {
        public int DeptNo { get; set; }

        [Required]
        public string DeptName { get; set; }
    }
}
