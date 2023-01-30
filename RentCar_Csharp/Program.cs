// Code de configuration initiale
using RentCar_Csharp.DB;
using Microsoft.EntityFrameworkCore;
using RentCar_Csharp.Models;


var context = new RentcarContext();
    context.RentalDB();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<RentcarContext>(opt => {
    opt.UseInMemoryDatabase("Users");
    opt.UseInMemoryDatabase("Cars");
    opt.UseInMemoryDatabase("Reservations");
    }
    );
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// To show the web page, write https://localhost:7257/swagger/index.html in the address bar
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

