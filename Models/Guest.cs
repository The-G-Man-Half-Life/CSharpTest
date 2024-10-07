using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpTest.Models;

[Table("Guests")]
public class Guest
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("guest_id")]
    public int Guest_id  {get; set;}

    [Column("guest_first_name")]
    public string Guest_first_name {get; set;}

    [Column("guest_last_name")]
    public string Guest_last_name {get; set;}

    [Column("guest_email")]
    public string Guest_email {get; set;}

    [Column("guest_identification_number")]
    public string Guest_identification_number {get; set;}

    [Column("guest_phone_number")]
    public string Guest_phone_number {get; set;}

    [Column("guest_birthdate")]
    public DateOnly? Guest_birthdate {get; set;}

    public Guest( string Guest_first_name ,string Guest_last_name ,string Guest_email ,string Guest_identification_number ,string Guest_phone_number ,DateOnly Guest_birthdate
    )
    {
        this.Guest_first_name = Guest_first_name;
        this.Guest_last_name = Guest_last_name;
        this.Guest_email = Guest_email;
        this.Guest_identification_number = Guest_identification_number;
        this.Guest_phone_number = Guest_phone_number;
        this.Guest_birthdate = Guest_birthdate;
    }
    public Guest() {}
}
