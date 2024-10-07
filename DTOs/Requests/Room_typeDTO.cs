using System.ComponentModel.DataAnnotations;

namespace CSharpTest.DTOs.Requests;
public class Room_typeDTO
{
    [Required(ErrorMessage = "El nombre del tipo de habitación es obligatorio.")]
    [StringLength(50, ErrorMessage = "El nombre no puede exceder los 50 caracteres.")]
    public string Room_type_name { get; set; }

    [StringLength(255, ErrorMessage = "La descripción no puede exceder los 255 caracteres.")]
    public string Room_type_description { get; set; }
}