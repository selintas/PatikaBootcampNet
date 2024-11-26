var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekleyin
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Statik dosyaları etkinleştirin
app.UseStaticFiles();

// Routing yapılandırmasını etkinleştirin
app.UseRouting();

// Varsayılan routing ekleyin
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

// Uygulamayı başlatın
app.Run();