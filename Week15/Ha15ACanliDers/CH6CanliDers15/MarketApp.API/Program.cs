using MarketApp.Business.Interfaces;
using MarketApp.Business.Services;
using MarketApp.DAL.Context;
using MarketApp.DAL.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(o => o.UseNpgsql(
    builder.Configuration.GetConnectionString("ApplicationDbContext")));
builder.Services.AddScoped(typeof(MarketApp.DAL.Repository.IRepository<>), typeof(EfRepository<>));
builder.Services.AddScoped<IProductService, ProductService>();

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
