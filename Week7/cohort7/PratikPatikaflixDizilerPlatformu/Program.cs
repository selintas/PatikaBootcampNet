using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    // Dizi Sınıfı
    public class Dizi
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int StartYear { get; set; }
        public string Director { get; set; }
        public string Platform { get; set; }
    }

    // Komedi Dizi Özeti Sınıfı
    public class KomediDiziOzeti
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
    }

    public static void Main()
    {
        List<Dizi> diziler = new List<Dizi>();
        bool devam = true;

        // Diziler Ekleniyor
        while (devam)
        {
            Dizi dizi = new Dizi();
            Console.Write("Dizi Adı: ");
            dizi.Name = Console.ReadLine();

            Console.Write("Yapım Yılı: ");
            dizi.Year = int.Parse(Console.ReadLine());

            Console.Write("Türü: ");
            dizi.Genre = Console.ReadLine();

            Console.Write("Yayınlanmaya Başlama Yılı: ");
            dizi.StartYear = int.Parse(Console.ReadLine());

            Console.Write("Yönetmen: ");
            dizi.Director = Console.ReadLine();

            Console.Write("Yayınlandığı İlk Platform: ");
            dizi.Platform = Console.ReadLine();

            diziler.Add(dizi);

            Console.Write("Yeni bir dizi eklemek ister misiniz? (E/H): ");
            string cevap = Console.ReadLine();
            devam = cevap.ToLower() == "e";
        }

        // Komedi Dizilerinden Yeni Bir Liste Oluşturuluyor
        var komediDizileri = diziler
            .Where(d => d.Genre.ToLower().Contains("komedi"))
            .Select(d => new KomediDiziOzeti
            {
                Name = d.Name,
                Genre = d.Genre,
                Director = d.Director
            })
            .OrderBy(d => d.Name)
            .ThenBy(d => d.Director)
            .ToList();

        // Komedi Dizilerini Yazdırma
        Console.WriteLine("\n--- Komedi Dizileri Listesi ---");
        foreach (var dizi in komediDizileri)
        {
            Console.WriteLine($"Dizi Adı: {dizi.Name}, Türü: {dizi.Genre}, Yönetmen: {dizi.Director}");
        }
    }
}