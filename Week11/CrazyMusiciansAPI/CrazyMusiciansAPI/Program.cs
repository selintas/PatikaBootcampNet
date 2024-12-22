var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy
        .AllowAnyHeader() // content-type..
        .AllowAnyMethod() // get, post, put, delete..
        .AllowAnyOrigin() // herhangi bir adres
    )
);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        // Swagger UI'nin ana rota adresini belirle
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Crazy Musicians API v1");
    });
}

app.UseHttpsRedirection();

app.UseCors(); // default policy kullanýlacak

app.UseAuthorization();

app.UseDefaultFiles(); // default acılacak soya: ındex.html
app.UseStaticFiles(); // wwwroot halka


app.MapControllers();

app.Run();
