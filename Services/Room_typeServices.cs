using System.Linq.Expressions;
using Bogus.DataSets;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using CSharpTest.Data;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;

namespace CSharpTest.Services;
public class Room_typeServices : IRoom_typeRepository
{
    public readonly ApplicationDbContext Context;

    public Room_typeServices(ApplicationDbContext context)
    {
        Context = context;
    }

    public async Task<IEnumerable<Room_type>> GetAll()
    {
        return await Context.Room_Types.ToListAsync();
    }
    public async Task<Room_type?> GetById(int id)
    {
        try
        {
            return await Context.Room_Types.FirstOrDefaultAsync(c => c.Room_type_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            throw new Exception("Un error ocurrio", dbEX);

        }
    }
    public async Task Add(Room_type Room_type)
    {
        if (Room_type == null)
        {
            throw new ArgumentNullException(nameof(Room_type), "ocurrio un error");
        }
        else
        {
            try
            {
                await Context.Room_Types.AddAsync(Room_type);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEX)
            {

                throw new Exception("Un error ocurrio", dbEX);
            }
        }

    }
    public async Task Update(Room_type Room_type)
    {
        if (Room_type == null)
        {
            throw new Exception("Un erro ocurrio");
        }

        else
        {
            try
            {
                Context.Update(Room_type);
                await Context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEX)
            {

                throw new Exception("Un error ocurrio", dbEX);

            }
        }

    }
    public async Task Delete(int id)
    {
        try
        {
            var Room_type = await GetById(id);
            if (Room_type != null)
            {
                Context.Room_Types.Remove(Room_type);
            }
            
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
                throw new Exception("Un error ocurrio", dbEX);
        }
    }
    public async Task<bool> CheckExistence(int id)
    {
        return await Context.Room_Types.AnyAsync(c => c.Room_type_id == id);
    }
}