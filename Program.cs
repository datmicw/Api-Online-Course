using Microsoft.EntityFrameworkCore;
using CourseManagementAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("http://localhost:5097");

// SQL SERVER
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("CourseDatabase")));

builder.Services.AddControllers();
var app = builder.Build();

// Map các controllers vào pipeline HTTP
app.MapControllers();

app.Run();
