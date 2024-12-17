using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVCCrudOrnek.Models;

namespace MVCCrudOrnek.Controllers
{
    public class OgrencilerController : Controller
    {

        public IActionResult Index()
        {
            List<OgrenciViewModel> ogrenciler = Veri.Ogrenciler
                .Select(o => new OgrenciViewModel()
                {
                    Id = o.Id,
                    Ad = o.Ad,
                    TuttuguTakim = Veri.Takimlar.First(t => t.Id == o.TakimId).TakimAd,
                    DogumYili = o.DogumYili
                })
                .ToList();

            return View(ogrenciler);
        }

        public IActionResult Yeni()
        {
            ViewBag.Takimlar = new SelectList(Veri.Takimlar, "Id", "TakimAd");
            return View();
        }

        [HttpPost]
        public IActionResult Yeni(YeniOgrenciViewModel ogrenci)
        {
            // VERİLERİN GEÇERLİLİĞİNİ KONTROL ET
            if (ModelState.IsValid)
            {
                // VERİLER GEÇERLİ İSE ÖĞRENCİYİ KAYDET VE ÖĞRENCİ LİSTESİNE YÖNLEN
                Ogrenci yeni = new Ogrenci()
                {
                    Id = Veri.Ogrenciler.Max(o => o.Id) + 1,
                    Ad = ogrenci.Ad,
                    DogumYili = ogrenci.DogumYili.Value,
                    TakimId = ogrenci.TakimId.Value
                };
                Veri.Ogrenciler.Add(yeni);

                // Bu controller'ın Index adındaki action'ına tarayıcıyı yönlendir
                TempData["Mesaj"] = "Yeni öğrenci başarıyla eklendi.";
                return RedirectToAction("Index");
            }

            // VERİLER GEÇERLİ DEĞİLSE AYNI SAYFAYI TEKRAR GÖSTER
            ViewBag.Takimlar = new SelectList(Veri.Takimlar, "Id", "TakimAd");
            return View();
        }

        // Ogrenciler/Duzenle/1
        public IActionResult Duzenle(int id)
        {
            Ogrenci? ogrenci = Veri.Ogrenciler.FirstOrDefault(o => o.Id == id);

            if (ogrenci == null)
                return NotFound();

            OgrenciDuzenleViewModel vm = new OgrenciDuzenleViewModel()
            {
                Id = ogrenci.Id,
                Ad = ogrenci.Ad,
                DogumYili = ogrenci.DogumYili,
                TakimId = ogrenci.TakimId
            };

            ViewBag.Takimlar = new SelectList(Veri.Takimlar, "Id", "TakimAd");
            return View(vm);
        }

        [HttpPost]
        public IActionResult Duzenle(OgrenciDuzenleViewModel vm)
        {
            Ogrenci? ogrenci = Veri.Ogrenciler.FirstOrDefault(o => o.Id == vm.Id);

            if (ogrenci == null) return NotFound();

            if (ModelState.IsValid)
            {
                ogrenci.Ad = vm.Ad;
                ogrenci.DogumYili = vm.DogumYili.Value;
                ogrenci.TakimId = vm.TakimId.Value;

                TempData["Mesaj"] = "Değişiklikler başarıyla kaydedildi.";
                return RedirectToAction("Index");
            }

            ViewBag.Takimlar = new SelectList(Veri.Takimlar, "Id", "TakimAd");
            return View(vm);
        }

        public IActionResult SilOnay(int id)
        {
            Ogrenci? ogrenci = Veri.Ogrenciler.FirstOrDefault(o => o.Id == id);

            if (ogrenci == null)
            {
                return NotFound();
            }

            return View(ogrenci);
        }

        [HttpPost]
        public IActionResult Sil(int id)
        {
            Ogrenci? ogrenci = Veri.Ogrenciler.FirstOrDefault(o => o.Id == id);

            if (ogrenci == null)
            {
                return NotFound();
            }

            Veri.Ogrenciler.Remove(ogrenci);
            TempData["Mesaj"] = "Öğrenci başarıyla silindi.";
            return RedirectToAction("Index");
        }
    }
}