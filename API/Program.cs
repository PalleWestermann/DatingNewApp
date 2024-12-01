using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// https://www.udemy.com/course/build-an-app-with-aspnet-core-and-angular-from-scratch/learn/lecture/44314812#announcements/10895371/
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt => 
{
  opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapControllers();

app.Run();
