using PropertiesFieldsMethods;

static void Main(string[] args)
{
    // Ogrenci sınıfı ve property örneği
    Ogrenci2 ogrenci = new Ogrenci2();
    ogrenci.Isim = "Ahmet"; // Property aracılığıyla değer atama
    Console.WriteLine("Öğrencinin İsmi: " + ogrenci.Isim); // Property aracılığıyla değer okuma

    // HesapMakinesi sınıfı ve method örneği
    HesapMakinesi hesapMakinesi = new HesapMakinesi();
    int toplam = hesapMakinesi.Topla(5, 3); // Method kullanarak toplama işlemi
    int carpim = hesapMakinesi.Carp(4, 6); // Method kullanarak çarpma işlemi
    Console.WriteLine("Toplam: " + toplam);
    Console.WriteLine("Çarpım: " + carpim);
}
