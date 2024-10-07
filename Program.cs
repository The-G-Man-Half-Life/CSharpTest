using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using CSharpTest.Data;
using CSharpTest.Repositories.Interfaces;
using CSharpTest.Services;

Env.Load();

var host = Environment.GetEnvironmentVariable("DB_HOST");
var port = Environment.GetEnvironmentVariable("DB_PORT");
var uid = Environment.GetEnvironmentVariable("DB_UID");
var database = Environment.GetEnvironmentVariable("DB_DATABASE");
var password = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={host};port={port};database={database};uid={uid};password={password}";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options=>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.20-mysql")));

builder.Services.AddScoped<IGuestRepository, GuestServices>();
builder.Services.AddScoped<GuestServices>();
builder.Services.AddScoped<IRoom_typeRepository, Room_typeServices>();
builder.Services.AddScoped<Room_typeServices>();
builder.Services.AddScoped<IRoomRepository, RoomServices>();
builder.Services.AddScoped<RoomServices>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeServices>();
builder.Services.AddScoped<EmployeeServices>();
builder.Services.AddScoped<IBookingRepository, BookingServices>();
builder.Services.AddScoped<BookingServices>();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
    {
        c.SwaggerDoc("v1", new OpenApiInfo { Title = "CSharpTest", Version = "v1" });
        c.SwaggerDoc("v2", new OpenApiInfo { Title = "CSharpTest", Version = "v2" });
        c.EnableAnnotations();
    }
);
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(
        options =>
        {
            options.SwaggerEndpoint("/swagger/v1/swagger.json", "Version 1");
            options.SwaggerEndpoint("/swagger/v2/swagger.json", "Version 2");
        }
    );
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();