using Bogus;
using CSharpTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpTest.Seeders;
public class GuestSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var Guests = GenerateGuests(100);
        modelBuilder.Entity<Guest>().HasData(Guests);
    }

    public static IEnumerable<Guest> GenerateGuests(int count)
    {    
        int _currentIndexId = 1; 
        var faker = new Faker<Guest>()
            .RuleFor(g=> g.Guest_id,f =>_currentIndexId ++)
            .RuleFor(g => g.Guest_first_name, f => f.Name.FirstName())
            .RuleFor(g => g.Guest_last_name, f => f.Name.LastName())
            .RuleFor(g => g.Guest_email, f => f.Internet.Email())
            .RuleFor(g => g.Guest_identification_number, f => f.Random.Long(1000000000, 9999999999).ToString())
            .RuleFor(g => g.Guest_phone_number, f => f.Random.Long(1000000000, 9999999999).ToString())
            .RuleFor(g => g.Guest_birthdate, f => DateOnly.FromDateTime(f.Date.Past(30)));
        return faker.Generate(count);
    }
}
