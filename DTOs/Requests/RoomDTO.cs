using System.ComponentModel.DataAnnotations;

namespace CSharpTest.DTOs.Requests;
public class RoomDTO
{
    [Required(ErrorMessage = "El número de habitación es obligatorio.")]
    [StringLength(10, ErrorMessage = "El número de habitación no puede exceder los 10 caracteres.")]
    public string Room_number { get; set; }

    [Required(ErrorMessage = "El precio por noche es obligatorio.")]
    [Range(0.01, double.MaxValue, ErrorMessage = "El precio por noche debe ser mayor que cero.")]
    public double Room_price_per_night { get; set; }

    [Required(ErrorMessage = "La disponibilidad es obligatoria.")]
    public bool Room_availability { get; set; }

    [Required(ErrorMessage = "La capacidad máxima de ocupantes es obligatoria.")]
    [Range(1, 255, ErrorMessage = "La capacidad máxima de ocupantes debe ser al menos 1.")]
    public int Room_max_occupancy_people { get; set; }

    [Required(ErrorMessage = "El ID del tipo de habitación es obligatorio.")]
    public int Room_type_id { get; set; }
}