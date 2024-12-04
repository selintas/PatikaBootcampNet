using Microsoft.AspNetCore.Mvc;
using MVCCrudOrnek.Models;

namespace MVCCrudOrnek.Controllers
{
    public class OgrencilerController : Controller
    {
        
        public IActionResult Index()
        {
            var Ogrenciler = Veri.Ogrenciler;

            return View(Ogrenciler);
        } 
         
        public IActionResult Yeni()
        {
            return View(); // verilerin tplanması için form boş
        }

        [HttpPost]
        public IActionResult Yeni(YeniOgrenciViewModel ogrenci) // ogrenci model sınıfıı modek sınıfına baglanıyor (Model bınding)
        {
            //VERİLERİN GEÇERLLİLİĞİ KONTROL ET 
            if (ModelState.IsValid) 
                /// VERİ GECERLİYSE KAYDET VE ÖĞRENCİ LİSTEYE YONLEN.
            {
                Ogrenci yeni = new Ogrenci();
                {
                    
                }; 
                Veri.Ogrenciler.Add(yeni);

                //Bu controllerın ındex adındakı actıona tarayıcı yonlendır. 
                return RedirectToAction("Index");
            }

            return View(); 
        }
    }
}
