using PlantShop.Application.Contracts;
using PlantShop.Application.Implementations.Services;
using PlantShop.Domain.Repositories;
using PlantShop.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPlantRepository, PlantRepository>();
builder.Services.AddScoped<IPlanterRepository, PlanterRepository>();
builder.Services.AddScoped<ITrendingPlantRepository, TrendingPlantRepository>();
builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

builder.Services.AddScoped<IPlantService, PlantService>();
builder.Services.AddScoped<IPlanterService, PlanterService>();
builder.Services.AddScoped<ITrendingPlantService, TrendingPlantService>();
builder.Services.AddScoped<IServicesService, ServicesService>();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(c => 
{
    c.AllowAnyHeader();
    c.AllowAnyMethod();
    c.AllowAnyOrigin();
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
