using DoyaDoyaAnadolu.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoyaDoyaAnadolu.Controllers
{
    public class BolgeController : Controller
    {
        private readonly TurkiyeContext _db;

        public BolgeController(TurkiyeContext db)
        {
            _db = db;
        }

        public IActionResult Index(int id)
        {
            Bolge? bolge = _db.Bolgeler
                .Include(b => b.Sehirler)
                .FirstOrDefault(b => b.Id == id);

            if (bolge == null)
                return NotFound();

            return View(bolge);
        }
    }
}
