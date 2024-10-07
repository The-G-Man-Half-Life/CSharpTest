using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpTest.Models;

[Table("Rooms")]
public class Room
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("room_id")]
    public int Room_id {get; set;}

    [Column("room_number")]
    public string Room_number {get; set;}

    [Column("room_price_per_night")]
    public double Room_price_per_night {get; set;}

    [Column("room_availability")]
    public bool Room_availability {get; set;}

    [Column("room_max_occupancy_people")]
    public int Room_max_occupancy_people {get; set;}

    [Column("room_type_id")]
    public int Room_type_id {get; set;}

    [ForeignKey(nameof(Room_type_id))]
    public Room_type? Room_Type {get; set;}

    public Room(string Room_number ,double Room_price_per_night ,bool Room_availability ,int Room_max_occupancy_people ,int Room_type_id)
    {
        this.Room_number = Room_number;
        this.Room_price_per_night = Room_price_per_night;
        this.Room_availability = Room_availability;
        this.Room_max_occupancy_people = Room_max_occupancy_people;
        this.Room_type_id = Room_type_id;
    }
    public Room() {}
}