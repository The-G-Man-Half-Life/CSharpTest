using Bogus;
using CSharpTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpTest.Seeders;
public class RoomSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var Rooms = GenerateRooms(50);
        modelBuilder.Entity<Room>().HasData(Rooms);
    }

    public static IEnumerable<Room> GenerateRooms(int count)
    {
        int id = 1; 


        
        var faker = new Faker<Room>()
                .RuleFor(s=> s.Room_id,f =>id ++)
                .RuleFor(s => s.Room_number, f => id.ToString())     
                .RuleFor(s => s.Room_type_id, f => f.Random.Int(1, 4))
                .RuleFor(s => s.Room_price_per_night, (f, s) => 
                {
                    return s.Room_type_id switch
                    {
                        1 => 50.0,
                        2 => 80.0,
                        3 => 150.0,
                        4 => 200.0,
                    };
                })
                .RuleFor(s => s.Room_availability, f => f.Random.Bool()) 
                .RuleFor(s => s.Room_max_occupancy_people, f => f.Random.Byte());
                


        return faker.Generate(count);
    }
}
