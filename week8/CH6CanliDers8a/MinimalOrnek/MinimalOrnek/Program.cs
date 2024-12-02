using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build(); // htttp üzerinden gelen istekleri dinler. 


// örnek ara yazılım  (middleware) oluşturalım.
//araya girip isteklerin cevaplanmasını
// tarayıcı tarafından html algılanması istedik 
app.Use(async (context, next) =>
{
    context.Response.
    ContentType = "text/html; charset=UTF-8"; // google.com F12 yaz http google tıkla networkte contenttpye ara oradan kopyala

    // next metot sıradakı işleme geç
    await next();

});

//ROUTİNG - ROTA OLUŞTURMA 

//.MapGet("/", () => "<h1>Siteme hoşgeldin</h1>"); // => anonım metot  
app.MapGet("/about", Hakkında ); // , den sonr METOT CAGIRDIK

app.MapGet("/", Anasayfam); // metot cagırdık 

string Anasayfam()
{
    return @"<h1>Siteme Hoşgeldiniz.</h1> 
            Hakkımda detaylı bilgi için
            <a href=""/about"">tıklayınız</a>. ";
} // "" kaçış karakteri
 
string Hakkında()
{
    return "<h1>Hakkında</h1>" +  
           "<p>benım adım Selin</p>" + 
           "<hr>" +
           "<a href=\"/\">Anasayfatya dön</a>";
}
https://github.com/yigith/CH6CanliDers7a
app.Run();
