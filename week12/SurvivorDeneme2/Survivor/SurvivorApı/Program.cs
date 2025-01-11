using Microsoft.EntityFrameworkCore;
using SurvivorApı.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 
var connectionString = builder.Configuration.GetConnectionString("BaglantiCumlem");
//var cs = builder.Configuration.GetConnectionString("BaglantıCümlem"); 

// DbContext'e bağlantı dizesini veriyoruz
builder.Services.AddDbContext<SurvivorDbContext>(options =>
    options.UseNpgsql(connectionString)
);
//builder.Services.AddDbContext<SurvivorDbContext>(builder => builder.UseNpgsql(cs));
builder.Services.AddControllersWithViews();

//builder.Services.AddControllers();
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

app.UseDefaultFiles(); // default açýlacak dosya: index.html
app.UseStaticFiles(); // wwwroot halka açýk


app.MapControllers();

app.Run();
