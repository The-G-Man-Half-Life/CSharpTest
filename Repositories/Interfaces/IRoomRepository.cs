using CSharpTest.DTOs.Requests;
using CSharpTest.Models;

namespace CSharpTest.Repositories.Interfaces;
public interface IRoomRepository
{
    Task<IEnumerable<Room>> GetAll();
    Task<RoomDTO?> GetById(int id);
    Task<Room?> GetById2(int id);
    Task Add(Room Room);
    Task Update(Room Room);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);
}