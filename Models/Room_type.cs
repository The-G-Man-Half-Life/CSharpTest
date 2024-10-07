using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpTest.Models;

[Table("RoomTypes")]
public class Room_type
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("room_type_id")]
    public int Room_type_id {get; set;}
    
    [Column("room_type_name")]
    public string Room_type_name {get; set;}
    
    [Column("room_type_description")]
    public string Room_type_description {get; set;}

    public Room_type(string Room_type_name, string Room_type_description)
    {
        this.Room_type_name = Room_type_name;
        this.Room_type_description = Room_type_description;
        
    }
    public Room_type() {}
}