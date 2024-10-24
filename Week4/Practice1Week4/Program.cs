class Program
{
    static void Main(string[] args)
    {
        // Öğrenci nesneleri oluşturuluyor
        Person ogrenci1 = new Person("Ali", "Yılmaz", new DateTime(2005, 7, 15));
        Person ogrenci2 = new Person("Ayşe", "Kara", new DateTime(2006, 3, 22));

        // Öğretmen nesneleri oluşturuluyor
        Person ogretmen1 = new Person("Ahmet", "Demir", new DateTime(1980, 11, 5));
        Person ogretmen2 = new Person("Fatma", "Ak", new DateTime(1975, 8, 18));

        // Öğrenci bilgileri konsola yazdırılıyor
        Console.WriteLine("Öğrenci Bilgileri:");
        ogrenci1.BilgileriYazdir();
        ogrenci2.BilgileriYazdir();

        // Öğretmen bilgileri konsola yazdırılıyor
        Console.WriteLine("\nÖğretmen Bilgileri:");
        ogretmen1.BilgileriYazdir();
        ogretmen2.BilgileriYazdir();
    }
}