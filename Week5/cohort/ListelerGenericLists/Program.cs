using System;
using System.Collections.Generic; // List<T> sınıfını kullanabilmek için bu namespace'i ekliyoruz

public class Program
{
    public static void Main()
    {
        // Generic List<T> kullanımı örneği

        // String tipinde bir List tanımlama ve eleman ekleme
        List<string> isimler = new List<string>();

        // Listeye eleman ekleme
        isimler.Add("Ahmet");
        isimler.Add("Mehmet");
        isimler.Add("Ayşe");

        // Listede bulunan elemanlara erişme ve ekrana yazdırma
        Console.WriteLine("İsimler:");
        foreach (string isim in isimler)
        {
            Console.WriteLine(isim);
        }

        // Listede bulunan elemanların sayısını yazdırma
        Console.WriteLine("Toplam İsim Sayısı: " + isimler.Count);

        // Integer tipinde bir List tanımlama ve eleman ekleme
        List<int> sayilar = new List<int>();

        // Listeye eleman ekleme
        sayilar.Add(10);
        sayilar.Add(20);
        sayilar.Add(30);

        // Listede bulunan elemanlara erişme ve ekrana yazdırma
        Console.WriteLine("Sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        // Listede bulunan elemanların toplamını hesaplama
        int toplam = 0;
        foreach (int sayi in sayilar)
        {
            toplam += sayi;
        }
        Console.WriteLine("Sayıların Toplamı: " + toplam);
    }
}

//Bu örnekte, List<T> sınıfını generic olarak kullandık. İlk olarak List<string> türünde bir liste oluşturduk ve içine bazı isimler ekledik. List<int> türünde bir liste daha oluşturarak içine sayılar ekledik. Daha sonra bu listelerdeki elemanlara erişip ekrana yazdırdık.

//Generic listeler, farklı veri tipleriyle çalışabilen dinamik koleksiyonlar sağlarlar. Bu sayede, farklı veri tiplerinde verileri kolayca saklayabilir, erişebilir ve işleyebiliriz. Listeler, dizilere kıyasla daha esnek bir veri yapıları seçeneği sunarlar, çünkü boyutları dinamik olarak değişebilir ve çeşitli işlevler ve özellikler (örneğin, Add, Remove, Count gibi) içerirler.