using PratikPolymorphism;

public class Program
{
    public static void Main(string[] args)
    {
        // Kare nesnesi oluşturma ve alan hesaplama
        BaseGeometrikSekil kare = new Kare { Genislik = 5, Yukseklik = 5 };
        Console.WriteLine("Karenin alanı: " + kare.AlanHesapla());

        // Dikdörtgen nesnesi oluşturma ve alan hesaplama
        BaseGeometrikSekil dikdortgen = new Dikdortgen { Genislik = 5, Yukseklik = 10 };
        Console.WriteLine($"Dikdörtgenin Alanı: {dikdortgen.AlanHesapla()}");

        // Dik Üçgen nesnesi oluşturma ve alan hesaplama
        BaseGeometrikSekil dikUcgen = new DikUcgen { Genislik = 5, Yukseklik = 10 };
        Console.WriteLine($"Dik Üçgenin Alanı: {dikUcgen.AlanHesapla()}");
    }
}