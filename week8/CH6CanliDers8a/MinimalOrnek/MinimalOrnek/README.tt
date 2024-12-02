# CH6 - Canlı Ders 8a

## Minimal Bir ASP.NET Core Uygulaması

### Uygulama Oluşturma ve Çalışmaya Hazır Hale Getirme
```csharp
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
```

### Custom Middleware (Arayazılım) Örneği
Dönen cevabın düz metin değil de bir html metni olduğunu ve karakter kodlamasının UTF-8 standardında olduğunu araya girerek (ara yazılım) belirtiyoruz.

```csharp
app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/html; charset=utf-8";
    await next();
});

```

### Routing (Rota Oluşturma)
```csharp
app.MapGet("/", Anasayfa);
app.MapGet("/about", Hakkinda); 


string Anasayfa()
{
    return "<h1>Websayfama hoş geldiniz</h1>" +
        "Ben <a href=\"/about\">kimim</a>?";
}

string Hakkinda()
{
    return "<h1>Benim adım <strong>Cafer</strong></h1>" +
        "Anasayfaya <a href=\"/\">dön</a>.";
}
```

### Uygulamanın Çalıştırılması
```app.Run()``` ifadesi, uygulamanın başlatılmasını ve gelen istekleri dinlemeye başlamasını sağlar. Bu, uygulamanın yaşam döngüsünü başlatan komuttur.

```csharp
app.Run();
```
