using Microsoft.AspNetCore.Mvc;
using IlkMvcUygulamam.Models;

namespace IlkMvcUygulamam.Controllers
{
    public class YasamController : Controller
    {
        // Yasam
        // Yasam/Index
        //[Route("ItsMyLife/ItsNow/Or/Never")]
        public IActionResult Index()
        {
            List<Hobi> model = Veri.Hobilerim()
                .OrderByDescending(h => h.Derece)
                .ToList();

            ViewBag.Cumle = "Hobiler, hayatın rutininden kaçış, ruhun özgürlüğüdür.";

            // ViewData["Cumle"] = "falan filan";

            return View(model);
        }

        // Yasam/Felsefem
        public string Felsefem()
        {
            return "Doğruyu söylediğin zaman başına gelenler senin için en doğru olandır.";
        }
    }
}
