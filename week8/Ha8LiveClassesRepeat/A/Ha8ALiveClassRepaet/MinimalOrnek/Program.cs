var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// örnek arayazılım (middleware) oluşturalım
// araya girip isteklerin cevaplarının
// tarayıcı tarafından html olarak algılanmasını istiyoruz

app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/html; charset=UTF-8"; // yazı karakterı duzenledı

    // sıradaki işlem
    await next();
});


// ROUTING
app.MapGet("/", Anasayfam);
app.MapGet("/about", Hakkinda);


string Anasayfam()
{
    return @"<h1>Siteme Hoşgeldiniz.</h1>
            Hakkımda detaylı bilgi için
            <a href=""/about"">tıklayınız</a>.";
}// basında @ olan cift tırnak "" kaçış özel isimlerde

string Hakkinda()
{
    return "<h1>Hakkında</h1>" +
           "<p>Benim adım Cafer.</p>" +
           "<hr>" +
           "<a href=\"/\">Anasayfaya dön</a>";
}

app.Run();