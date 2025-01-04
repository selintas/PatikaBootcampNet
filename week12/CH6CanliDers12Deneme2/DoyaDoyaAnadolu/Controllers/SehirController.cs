using DoyaDoyaAnadolu.Data;
using Microsoft.AspNetCore.Mvc;

namespace DoyaDoyaAnadolu.Controllers
{
    public class SehirController : Controller
    {
        private readonly TurkiyeContext _db;

        public SehirController(TurkiyeContext db)
        {
            _db = db;
        }

        public IActionResult Index(int id)
        {
            Sehir? sehir = _db.Sehirler.Find(id);

            if (sehir == null)
                return NotFound();

            // EXPLICIT LOADING
            _db.Entry(sehir).Reference(s => s.Bolge).Load();

            return View(sehir);
        }
    }
}