

using System;
using System.Collections.Generic;

class Program
{
    // Film sınıfı tanımlama
    public class Film
    {
        public string Isim { get; set; }
        public double ImdbPuani { get; set; }

        public Film(string isim, double imdbPuani)
        {
            Isim = isim;
            ImdbPuani = imdbPuani;
        }
    }

    static void Main()
    {
        List<Film> filmler = new List<Film>(); // Film listesi oluşturma
        bool devamEt = true; // Kullanıcı yanıtına göre döngüyü kontrol etmek için

        while (devamEt)
        {
            // Kullanıcıdan film bilgilerini alma
            Console.Write("Film Adı: ");
            string isim = Console.ReadLine();

            Console.Write("IMDb Puanı: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))
            {
                Console.Write("Lütfen geçerli bir IMDb puanı girin: ");
            }

            // Film nesnesi oluşturma ve listeye ekleme
            filmler.Add(new Film(isim, imdbPuani));

            // Yeni film eklemek isteyip istemediğini sorma
            Console.Write("Yeni bir film eklemek istiyor musunuz? (evet/hayır): ");
            string cevap = Console.ReadLine().ToLower();
            if (cevap != "evet")
            {
                devamEt = false;
            }
        }

        // Tüm filmleri listeleme
        Console.WriteLine("\n--- Tüm Filmler ---");
        foreach (var film in filmler)
        {
            Console.WriteLine($"Film Adı: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
        }

        // IMDb puanı 4 ile 9 arasında olan filmleri listeleme
        Console.WriteLine("\n--- IMDb Puanı 4 ile 9 Arasında Olan Filmler ---");
        foreach (var film in filmler)
        {
            if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
            {
                Console.WriteLine($"Film Adı: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }
        }

        // İsmi 'A' ile başlayan filmleri listeleme
        Console.WriteLine("\n--- İsmi 'A' ile Başlayan Filmler ---");
        foreach (var film in filmler)
        {
            if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"Film Adı: {film.Isim}, IMDb Puanı: {film.ImdbPuani}");
            }
        }
    }
}