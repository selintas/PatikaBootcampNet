using Microsoft.EntityFrameworkCore;
using Survivor.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add services to the container.
var cs = builder.Configuration.GetConnectionString("BaglantıCümlem");
builder.Services.AddDbContext<SurvivorDbContext>(builder => builder.UseNpgsql(cs));
builder.Services.AddControllersWithViews();

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
