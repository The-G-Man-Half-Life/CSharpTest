using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpTest.Models;

[Table("Bookings")]
public class Booking
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("booking_id")]
    public int Booking_id {get; set;}

    [Column("booking_start_date")]
    public DateTime? Booking_start_date {get; set;}

    [Column("booking_end_date")]
    public DateTime? Booking_end_date {get; set;}

    [Column("booking_total_cost")]
    public double Booking_total_cost {get; set;}

    [Column("Booking_room_id")]
    public int Booking_room_id {get; set;}

    [ForeignKey(nameof(Booking_room_id))]
    public Room? Room {get; set;}

    [Column("Booking_guest_id")]
    public int Booking_guest_id {get; set;}

    [ForeignKey(nameof(Booking_guest_id))]
    public Guest? Guest {get; set;}

    [Column("Booking_employee_id")]
    public int Booking_employee_id {get; set;}

    [ForeignKey(nameof(Booking_employee_id))]
    public Employee? Employee {get; set;}

    public Booking(DateTime Booking_start_date ,DateTime Booking_end_date ,double Booking_total_cost ,int Booking_room_id ,int Booking_guest_id ,int Booking_employee_id)
    {
        this.Booking_start_date = Booking_start_date;
        this.Booking_end_date = Booking_end_date;
        this.Booking_total_cost = Booking_total_cost;
        this.Booking_room_id = Booking_room_id;
        this.Booking_guest_id = Booking_guest_id;
        this.Booking_employee_id = Booking_employee_id;
    }
    public Booking() {}
}