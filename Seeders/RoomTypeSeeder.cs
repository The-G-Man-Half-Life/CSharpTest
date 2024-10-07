using Bogus;
using CSharpTest.Models;
using Microsoft.EntityFrameworkCore;

namespace CSharpTest.Seeders;
public class Room_typeSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
            modelBuilder.Entity<Room_type>().HasData(
    new Room_type
    {
        Room_type_id = 1,
        Room_type_name = "Habitación Simple",
        Room_type_description = "Una acogedora habitación básica con una cama individual, ideal para viajeros solos."
    },
    new Room_type
    {
        Room_type_id = 2,
        Room_type_name = "Habitación Doble",
        Room_type_description = "Ofrece flexibilidad con dos camas individuales o una cama doble, perfecta para parejas o amigos."
    },
    new Room_type
    {
        Room_type_id = 3,
        Room_type_name = "Suite",
        Room_type_description = "Espaciosa y lujosa, con una cama king size y una sala de estar separada, ideal para quienes buscan confort y exclusividad."
    },
    new Room_type
    {
        Room_type_id = 4,
        Room_type_name = "Habitación Familiar",
        Room_type_description = "Diseñada para familias, con espacio adicional y varias camas para una estancia cómoda."
    }
        );
    }
}
