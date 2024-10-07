using CSharpTest.DTOs.Requests;
using CSharpTest.Models;

namespace CSharpTest.Repositories.Interfaces;
public interface IBookingRepository
{
    Task<IEnumerable<Booking>> GetAll();
    Task<BookingDTO?> GetById(int id);
    Task<Booking?> GetById2(int id);
    Task Add(Booking Booking);
    Task Update(Booking Booking);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}