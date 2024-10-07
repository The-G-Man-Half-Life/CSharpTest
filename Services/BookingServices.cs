using Microsoft.EntityFrameworkCore;
using CSharpTest.Data;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.DTOs.Requests;

namespace CSharpTest.Services;

public class BookingServices : IBookingRepository
{
    private readonly ApplicationDbContext Context;

    public BookingServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }

    public async Task<IEnumerable<Booking>> GetAll()
    {
        try
        {
            var Bookings = await Context.Bookings.Select(s => new Booking
            {
                Booking_id = s.Booking_id,
                Booking_start_date = s.Booking_start_date,
                Booking_end_date = s.Booking_end_date,
                Booking_total_cost = s.Booking_total_cost,
                Booking_room_id = s.Booking_room_id,
                Booking_guest_id = s.Booking_guest_id,
                Booking_employee_id = s.Booking_employee_id
            }).ToListAsync();


            return Bookings;
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task<BookingDTO?> GetById(int id){

        try
        {
            var BookingModel = await Context.Bookings.FirstOrDefaultAsync(s=>s.Booking_id == id);
            var Booking = new BookingDTO
            {
                Booking_start_date = (DateTime)BookingModel.Booking_start_date,
                Booking_end_date = (DateTime)BookingModel.Booking_end_date,
                Booking_total_cost = BookingModel.Booking_total_cost,
                Booking_room_id = BookingModel.Booking_room_id,
                Booking_guest_id = BookingModel.Booking_guest_id,
                Booking_employee_id = BookingModel.Booking_employee_id

            };
            return Booking;
        }

        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
}
    public async Task<Booking?> GetById2(int id){

        try
        {
            return await Context.Bookings.FirstOrDefaultAsync(s=>s.Booking_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task Add(Booking Booking){
        if (Booking == null)
        {
            throw new ArgumentNullException(nameof(Booking), "un error ocurrio");
        }
        else
        {
            try
            {
                await Context.Bookings.AddAsync(Booking);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEX)
            {

                throw new Exception("Un error ocurrio", dbEX);
            }
        }
    }

    public async Task Update(Booking Booking){
        try
        {
            Context.Bookings.Update(Booking);
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
            var user = await Context.Bookings.FirstOrDefaultAsync(s=>s.Booking_id == id);
            if(user != null){
                Context.Bookings.Remove(user);
            }
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception($"Un error ocurrio {dbEX.Message}");
        }
    }

    public async Task<bool> CheckExistence(int id){
        return await  Context.Bookings.AnyAsync(s=>s.Booking_id==id);
    }

}