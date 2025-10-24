using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

var app = builder.Build();


app.UseMiddleware<RequestLoggingMiddleware>();
app.UseRouting();
app.MapControllers();

app.Run();