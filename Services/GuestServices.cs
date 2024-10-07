using Microsoft.EntityFrameworkCore;
using CSharpTest.Data;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;

namespace CSharpTest.Services;
public class GuestServices: IGuestRepository
{
    public readonly ApplicationDbContext Context;

    public GuestServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }
    public async Task<IEnumerable<Guest>> GetAll()
    {
        try
        {
            return await Context.Guests.ToListAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task<Guest?> GetById(int id)
    {
        try
        {
            return await Context.Guests.FirstOrDefaultAsync(b=>b.Guest_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Add(Guest Guest)
    {
        try
        {
            await Context.Guests.AddAsync(Guest);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Update(Guest Guest)
    {
        try
        {
            Context.Guests.Update(Guest);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Delete(int id)
    {
        try
        {
            var GuestFound = await GetById(id);
            Context.Guests.Remove(GuestFound);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await Context.Guests.AnyAsync(b=>b.Guest_id == id); 

    }

}