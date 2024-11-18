// LINQ (Language Integrated Query)
//LINQ, SQL benzeri ifadeler kullanarak koleksiyonlarda (liste, dizi, vb.) veri sorgulamak için kullanılır ve bu sorguları compile-time olarak type-safe (derleme zamanı güvenli) hale getirir.
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Örnek bir liste oluşturalım
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ kullanarak çift sayıları seçelim
        var evenNumbers = numbers.Where(x => x % 2 == 0);

        // Seçilen çift sayıları ekrana yazdıralım
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }
    }
}
//Bu örnekte, numbers adında bir liste tanımlıyoruz ve LINQ kullanarak bu listenin içinden çift sayıları seçiyoruz. LINQ ifadesi olan Where metodu bir lambda ifadesi (x => x % 2 == 0) alır ve bu ifadeyle liste elemanlarını filtreler. Sonuç olarak evenNumbers değişkeni, filtrelenmiş çift sayıları içerir.

//LINQ'nun bu örnekte sağladığı avantajlar şunlardır:

//LINQ ifadeleri okunabilirlik sağlar ve kodu daha kısa tutar.

//Compile-time type-checking sayesinde hatalar compile-time'da yakalanır.

//SQL benzeri ifadeler kullanarak veri manipülasyonu yapabiliriz.

//LINQ, veritabanı sorgulamaları, XML işlemleri, koleksiyon sorguları ve diğer veri işleme işlemleri için yaygın olarak kullanılır.