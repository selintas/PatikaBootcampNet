using System;

public class Program
{
    // Generic bir metot örneği: iki farklı türde parametre alan ve sonuç döndüren bir metot
    public static T Topla<T>(T sayi1, T sayi2)
    {
        dynamic s1 = sayi1;
        dynamic s2 = sayi2;
        return s1 + s2;
    }

    public static void Main()
    {
        // int türü için Topla metodu kullanımı
        int sonuc1 = Topla<int>(5, 10);
        Console.WriteLine("Toplam (int): " + sonuc1);

        // double türü için Topla metodu kullanımı
        double sonuc2 = Topla<double>(3.5, 2.7);
        Console.WriteLine("Toplam (double): " + sonuc2);

        // string türü için Topla metodu kullanımı
        string sonuc3 = Topla<string>("Merhaba ", "Dünya");
        Console.WriteLine("Birleştirme (string): " + sonuc3);
    }
}

//Bu örnekte, Topla<T> adında bir generic metot tanımladık. Bu metot, T tipinde iki parametre alıyor ve bu parametreleri toplayarak veya birleştirerek geri döndürüyor. T tipi, metodu çağırdığımız yerde belirli bir veri türüyle yer değiştirir.

//Topla<int>(5, 10) şeklinde çağrıldığında, T int olarak yerine geçer ve iki integer sayı toplanır.

//Topla<double>(3.5, 2.7) şeklinde çağrıldığında, T double olarak yerine geçer ve iki double sayı toplanır.

//Topla<string>("Merhaba ", "Dünya") şeklinde çağrıldığında, T string olarak yerine geçer ve iki string birleştirilir.

//Generic metotlar, farklı veri tipleriyle çalışabilen ve tip güvenliği sağlayan kod blokları oluşturmamıza olanak tanır. Bu sayede, kod tekrarını azaltabilir ve daha esnek yazılım bileşenleri oluşturabiliriz.

