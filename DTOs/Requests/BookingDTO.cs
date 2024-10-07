using System.ComponentModel.DataAnnotations;

namespace CSharpTest.DTOs.Requests;
public class BookingDTO
{
        [Required]
        public DateTime Booking_start_date { get; set; }

        [Required]
        public DateTime Booking_end_date { get; set; }

        [Required]
        public double Booking_total_cost { get; set; }

        [Required]
        public int Booking_room_id { get; set; }

        [Required]
        public int Booking_guest_id { get; set; }

        [Required]
        public int Booking_employee_id { get; set; }
}