using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PratikPatikaKütüphane
{
    public class Kitap 
    {
        //Properties
        public string Ad { get; set; }
        public string YazarAd { get; set; }
        public string YazarSoyad { get; set; }
        public int SayfaSayisi { get; set; }
        public string Yayinevi { get; set; }
        public DateTime KayitTarihi { get; private set; }

        // 1. Default Constructor (Parametresiz)
        public Kitap()
        {
            KayitTarihi = DateTime.Now; // Kayıt tarihi, nesne oluşturulduğunda otomatik atanır.

        }
        // 2. Constructor with parameters
        public Kitap(String ad, string yazarAd, string yazarSoyad, int sayfaSayisi, string yayinevi) : this()
        {
            Ad = ad;
            YazarAd = yazarAd;
            SayfaSayisi = sayfaSayisi;
            Yayinevi = yayinevi;
        }
        // Kitap bilgilerini yazdırmak için bir yardımcı metod
        public void KitapBilgiYazdır()
        {
            Console.WriteLine($"Kitap Adı: {Ad}");
            Console.WriteLine($"Yazar: {YazarAd} {YazarSoyad}");
            Console.WriteLine($"Sayfa Sayısı: {SayfaSayisi}");
            Console.WriteLine($"Yayınevi: {Yayinevi}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
            Console.WriteLine();

        }
    }
}
