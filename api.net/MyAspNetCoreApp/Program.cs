using Microsoft.EntityFrameworkCore;
using MyAspNetCoreApp.Data;
using MyAspNetCoreApp.Controllers;

var builder = WebApplication.CreateBuilder(args);

// Регистрация DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=app.db"));

// Регистрация контроллеров
builder.Services.AddControllers();

var app = builder.Build();

// Middleware pipeline
app.UseRouting();
app.MapControllers(); // Включает маршрутизацию для [ApiController]

app.Run();