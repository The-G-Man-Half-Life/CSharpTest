using CSharpTest.Models;
using CSharpTest.Seeders;
using Microsoft.EntityFrameworkCore;


namespace CSharpTest.Data;
public class ApplicationDbContext: DbContext
{
    public DbSet<Guest> Guests {get; set;}
    public DbSet<Room_type> Room_Types {get; set;}
    public DbSet<Room> Rooms {get; set;}

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        Room_typeSeeder.Seed(modelBuilder);
        GuestSeeder.Seed(modelBuilder);
        RoomSeeder.Seed(modelBuilder);

    }
}