using Bogus;
using CSharpTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpTest.Seeders;
public class Employeeseeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var Employees = GenerateEmployees(5);
        modelBuilder.Entity<Employee>().HasData(Employees);
    }

    public static IEnumerable<Employee> GenerateEmployees(int count)
    {    
        int _currentIndexId = 1; 
        var faker = new Faker<Employee>()
            .RuleFor(g=> g.Employee_id,f =>_currentIndexId ++)
            .RuleFor(g => g.Employee_first_name, f => f.Name.FirstName())
            .RuleFor(g => g.Employee_last_name, f => f.Name.LastName())
            .RuleFor(g => g.Employee_email, f => f.Internet.Email())
            .RuleFor(g => g.Employee_identification_number, f => f.Random.Long(1000000000, 9999999999).ToString())
            .RuleFor(g => g.Employee_password, f => f.Random.AlphaNumeric(20));
        return faker.Generate(count);
    }
}
