
using HotelesAPP.ApiService.Aplication.Services;
using HotelesAPP.ApiService.Controllers;
using HotelesAPP.ApiService.Domain.Repositories;
using HotelesAPP.ApiService.Infraestructure;

var builder = WebApplication.CreateBuilder(args);

// Add service defaults & Aspire client integrations.
builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddProblemDetails();

builder.Services.AddScoped<HotelController>();
builder.Services.AddScoped<IHotelService, HotelService>();
builder.Services.AddScoped<IHotelRepository, HotelRepository>();



// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseExceptionHandler();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}


// Get All Hoteles
app.Map("/hoteles",(HotelController hotelController) =>
{    return hotelController.GetHoteles();

}).WithDisplayName("GetHoteles");

// Get Hotel by Id
app.Map("/hoteles/{id:int}",(int id, HotelController hotelController) =>
{
    return hotelController.GetHotelById(id);
    
}).WithDisplayName("GetHotelById");

app.Run();


