using ControllerProblem.Interface;
using ControllerProblem.Services;
using ControllerProblem.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; // Add this namespace for extension methods like UseInMemoryDatabase  

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.  

builder.Services.AddDbContext<AppDbContext>(options =>
   options.UseInMemoryDatabase("OrdersDb"));
builder.Services.AddScoped<IOrderService, OrderService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle  
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
