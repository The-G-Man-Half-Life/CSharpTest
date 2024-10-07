using Microsoft.EntityFrameworkCore;
using CSharpTest.Data;
using CSharpTest.Models;
using CSharpTest.Repositories.Interfaces;

namespace CSharpTest.Services;
public class EmployeeServices: IEmployeeRepository
{
    public readonly ApplicationDbContext Context;

    public EmployeeServices(ApplicationDbContext Context)
    {
        this.Context = Context;
    }
    public async Task<IEnumerable<Employee>> GetAll()
    {
        try
        {
            return await Context.Employees.ToListAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task<Employee?> GetById(int id)
    {
        try
        {
            return await Context.Employees.FirstOrDefaultAsync(b=>b.Employee_id == id);
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Add(Employee Employee)
    {
        try
        {
            await Context.Employees.AddAsync(Employee);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task Update(Employee Employee)
    {
        try
        {
            Context.Employees.Update(Employee);
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
            var EmployeeFound = await GetById(id);
            Context.Employees.Remove(EmployeeFound);
            await Context.SaveChangesAsync();
        }
        catch (DbUpdateException dbEX)
        {
            
            throw new Exception("Un error ocurrio",dbEX);
        }
    }

    public async Task<bool> CheckExistence(int id)
    {
        return await Context.Employees.AnyAsync(b=>b.Employee_id == id); 

    }

}