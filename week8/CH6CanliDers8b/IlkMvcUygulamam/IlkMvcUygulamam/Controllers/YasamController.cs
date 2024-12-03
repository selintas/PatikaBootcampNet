using IlkMvcUygulamam.Models;
using Microsoft.AspNetCore.Mvc;

namespace IlkMvcUygulamam.Controllers
{
    public class YasamController : Controller
    {
        // Yasam/ındex = /Yasam aynı
        //[Route("ItsMyLife/ItsNow/OR")]
        public IActionResult Index()
        { 
            List<Hobi> model =Veri.Hobilerim().OrderByDescending(h => h.Derece).ToList();

            ViewBag.Cumle = "Hobiler bir kaçış.";

            // ViewData["Cumle"] = "Falan filan"; bunu yazar.

            return View(model);
        }
        //Yasam/Felsefem
        public string Felsefem()
        {
            return "Doğruyu söyleyen";
        }
    }
}
