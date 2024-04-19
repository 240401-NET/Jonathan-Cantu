using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Grocery.Data;
using Grocery.Models;
using Services;
using Azure.Core.Pipeline;



var builder = WebApplication.CreateBuilder(args);

Console.WriteLine(builder.Configuration["dbconn"]);
builder.Services.AddDbContext<GroceryDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("dbconn")));
builder.Services.AddControllers();
builder.Services.AddScoped<IGroceryService, GroceryService>();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddScoped<IRepository, GroceryRepository>();
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

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

 app.MapGet("/Groceries",(IRepository repo) =>{
     return repo.GetAllGroceries();})
     .WithName("Get All Groceries")
     .WithOpenApi();
     
app.MapPost("/AddGroceryItem", (IRepository repo, Item itemToCreate) =>{
return repo.CreateNewItem(itemToCreate);})
.WithName("Add A Item To Groceries")
.WithOpenApi();


app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
