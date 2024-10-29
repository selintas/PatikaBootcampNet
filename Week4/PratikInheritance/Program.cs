public class Program
{
    public static void Main(string[] args)
    {
        // Öğrenci nesnesi oluşturma ve değer atama
        Ogrenci ogrenci1 = new Ogrenci
        {
            Ad = "Ali",
            Soyad = "Yılmaz",
            OgrenciNo = 12345
        };

        // Öğretmen nesnesi oluşturma ve değer atama
        Ogretmen ogretmen1 = new Ogretmen
        {
            Ad = "Ahmet",
            Soyad = "Demir",
            Maas = 4500
        };

        // Bilgileri yazdırma
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci1.YazdirOgrenciBilgileri();

        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen1.OgretmenBilgi();
    }
}
