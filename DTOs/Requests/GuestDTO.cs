using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CSharpTest.DTOs.Requests;

public class GuestDTO
{
    [Required]
    [StringLength(255, ErrorMessage = "El nombre no puede exceder los 255 caracteres.")]
    public string First_name { get; set; }

    [Required]
    [StringLength(255, ErrorMessage = "El apellido no puede exceder los 255 caracteres.")]
    public string Last_name { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
    [StringLength(255, ErrorMessage = "El correo electrónico no puede exceder los 255 caracteres.")]
    public string Email { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "El número de identificación no puede exceder los 20 caracteres.")]
    public string Identification_number { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "El número de teléfono no puede exceder los 20 caracteres.")]
    public string Phone_number { get; set; }

    [Required]
    [DataType(DataType.Date, ErrorMessage = "La fecha debe estar en el formato correcto.")]
    public DateOnly Birthdate { get; set; }

}
