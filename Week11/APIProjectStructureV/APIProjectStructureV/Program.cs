// ASP.NET Core Minimal API

// yapılandırma 
var builder = WebApplication.CreateBuilder(args); //Mınımal apı use controller secılmedı balarken


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer(); // apı otomatık kesfeder ekler
builder.Services.AddSwaggerGen(); // swager dokumastasları olusturur

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment()) // ortam geliştirme de çalışıyorsak bunları aktıflestır

{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // http isteklerını yonlendırır auto

var summaries = new[] // hava drumu ozetı olarak dızı tanımlanmıs
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
