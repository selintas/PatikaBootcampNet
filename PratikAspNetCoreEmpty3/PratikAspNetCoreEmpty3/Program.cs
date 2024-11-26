

//MVC Servislerinin Eklenmesi

var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekleyin
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Statik Dosyaların Kullanımı

// Statik dosyaların kullanımını etkinleştirin
app.UseStaticFiles();


//Routing Konfigürasyonu

// Routing yapılandırmasını etkinleştirin
app.UseRouting();

// Varsayılan route ekleyin

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}"); // bu bızımkı derste


// Varsayılan route ekleyin
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//}); chatcpt onerısı

app.Run(); // ile uygullama calısır.