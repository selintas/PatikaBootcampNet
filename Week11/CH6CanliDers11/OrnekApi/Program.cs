var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options => options.AddDefaultPolicy(policy =>
    policy
        .AllowAnyHeader() // content-type..
        .AllowAnyMethod() // get, post, put, delete..
        .AllowAnyOrigin() // herhangi bir adres // bunlar izin verir ayrıca altta CORS EKLENDI.
    )
);
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

app.UseCors(); // default policy kullan�lacak

app.UseAuthorization();

app.UseDefaultFiles(); // default a��lacak dosya: index.html
app.UseStaticFiles(); // wwwroot halka a��k

app.MapControllers();

app.Run();