using ElectronicsShop.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;  // Add AutoMapper
using ElectronicsShop;
using ElectronicsShop.Mappings;  // Add the namespace for MappingProfile

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Add AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));
// Register AutoMapper and your MappingProfile

// Add CORS (if needed)
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});   

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

// Enable CORS (if needed)
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
