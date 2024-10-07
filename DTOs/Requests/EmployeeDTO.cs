using System.ComponentModel.DataAnnotations;

namespace CSharpTest.DTOs.Requests;
public class EmployeeDTO
{
        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
        public string Employee_first_name { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El apellido no puede exceder los 50 caracteres.")]
        public string Employee_last_name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
        [StringLength(255, ErrorMessage = "El correo electrónico no puede exceder los 50 caracteres.")]
        public string Employee_email { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El número de identificación no puede exceder los 255 caracteres.")]
        public string Employee_identification_number { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "La contraseña no puede exceder los 255 caracteres.")]
        public string Employee_password { get; set; }

}