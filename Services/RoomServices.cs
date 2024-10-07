using Microsoft.EntityFrameworkCore;
using CSharpTest.Data;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Services;

public class RoomServices : IRoomRepository
{
    private readonly ApplicationDbContext Context;

    public RoomServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<Room>> GetAll()
    {
        try
        {
            var Rooms = await Context.Rooms.Select(s => new Room
            {
                Room_id = s.Room_id,
                Room_number = s.Room_number,
                Room_price_per_night = s.Room_price_per_night,
                Room_availability = s.Room_availability,
                Room_max_occupancy_people = s.Room_max_occupancy_people,
                Room_type_id = s.Room_type_id,
            }).ToListAsync();


            return Rooms;
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task<RoomDTO?> GetById(int id){

        try
        {
            var RoomModel = await Context.Rooms.FirstOrDefaultAsync(s=>s.Room_id == id);
            var Room = new RoomDTO
            {
                Room_number = RoomModel.Room_number,
                Room_price_per_night = RoomModel.Room_price_per_night,
                Room_availability = RoomModel.Room_availability,
                Room_max_occupancy_people = RoomModel.Room_max_occupancy_people,
                Room_type_id = RoomModel.Room_type_id,
            };
            return Room;
        }

        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
}
    public async Task<Room?> GetById2(int id){

        try
        {
            return await Context.Rooms.FirstOrDefaultAsync(s=>s.Room_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task Add(Room Room){
        if (Room == null)
        {
            throw new ArgumentNullException(nameof(Room), "un error ocurrio");
        }
        else
        {
            try
            {
                await Context.Rooms.AddAsync(Room);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEX)
            {

                throw new Exception("Un error ocurrio", dbEX);
            }
        }
    }

    public async Task Update(Room Room){
        try
        {
            Context.Rooms.Update(Room);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task Delete(int id){
        try
        {
            var user = await Context.Rooms.FirstOrDefaultAsync(s=>s.Room_id == id);
            if(user != null){
                Context.Rooms.Remove(user);
            }
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task<bool> CheckExistence(int id){
        return await  Context.Rooms.AnyAsync(s=>s.Room_id==id);
    }

}