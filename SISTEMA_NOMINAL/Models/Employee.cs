using System.ComponentModel.DataAnnotations;

namespace SistemaNomina.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }

        [Required]
        public string CI { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public char Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Required]
        [EmailAddress]
        public string Correo { get; set; }
    }
}
