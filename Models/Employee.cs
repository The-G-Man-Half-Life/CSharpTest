using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSharpTest.Models;

[Table("Employee")]
public class Employee
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("employee_id")]
    public int Employee_id  {get; set;}

    [Column("employee_first_name")]
    public string Employee_first_name {get; set;}

    [Column("employee_last_name")]
    public string Employee_last_name {get; set;}

    [Column("employee_email")]
    public string Employee_email {get; set;}

    [Column("employee_identification_number")]
    public string Employee_identification_number {get; set;}

    [Column("employee_password")]
    public string Employee_password {get; set;}

    public Employee( string Employee_first_name ,string Employee_last_name ,string Employee_email ,string Employee_identification_number ,string Employee_password
    )
    {
        this.Employee_first_name = Employee_first_name;
        this.Employee_last_name = Employee_last_name;
        this.Employee_email = Employee_email;
        this.Employee_identification_number = Employee_identification_number;
        this.Employee_password = Employee_password;
    }
    public Employee() {}
}
