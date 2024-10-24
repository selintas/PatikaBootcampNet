using ClassesandObjects;

class Program // Öğrenci Nesnesi Oluşturma ve Kullanma
{
    static void Main(string[] args)
    {
        // Ogrenci sınıfından yeni bir nesne oluşturma
        Ogrenci1 ogrenci1 = new Ogrenci1();

        // Ogrenci nesnesinin alanını belirleme
        ogrenci1.Ad = "Ali";

        // Ogrenci nesnesinin metodu çağırma
        ogrenci1.SelamVer(); // Merhaba, ben Ali!
    }
}