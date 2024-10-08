using System;

class Program
{
    static void Main(string[] args)
    {
        // Kullanıcıdan bilgileri alma
        Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz:");
        Console.Write("T.C. Kimlik Numaranızı: ");
        string tcKimlikNo = Console.ReadLine(); // T.C. Kimlik numarası için string kullanıldı

        Console.Write("Adı: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadı: ");
        string soyad = Console.ReadLine();

        Console.Write("Telefon Numarası: ");
        string telefonNo = Console.ReadLine();
        // Telefon numarası için string veri tipi kullanıldı çünkü sayısal bir işlem yapılmayacak.
        // Ayrıca telefon numarasının başındaki sıfırı kaybetmemek ve özel karakterler (örn: +90) kullanabilmek için string daha uygun.

        Console.Write("Yaş: ");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.Write("İlk Aldığı Ürünün Fiyatı: ");
        double ilkUrunFiyati = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci Aldığı Ürünün Fiyatı: ");
        double ikinciUrunFiyati = Convert.ToDouble(Console.ReadLine());
        // Ürün fiyatları için double veri tipi kullanıldı çünkü fiyatlar ondalıklı sayılar içerebilir 
        // ve parasal değerleri temsil etmek için double uygun bir seçenektir.

        // Toplam fiyatı hesapla
        double toplamFiyat = ilkUrunFiyati + ikinciUrunFiyati;

        // Patika puanını hesapla (toplam harcamanın %10'u)
        double patikaPuan = toplamFiyat * 0.10;

        // Kullanıcıya sonuç mesajı göster
        Console.WriteLine("\n---------------------------------------------------");
        Console.WriteLine($"{tcKimlikNo} Tc numaralı {ad} {soyad} isimli kişi için kayıt oluşturulmuştur.");
        Console.WriteLine($"{telefonNo} telefon numarasına bildirim mesajı gönderilmiştir.");
        Console.WriteLine($"{toplamFiyat} toplam harcama karşılığı kazanılan %10'luk patika puan miktarı -> {patikaPuan} TL'dir.");
    }
}