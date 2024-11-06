using System;
using System.Linq; // Diziyi sıralamak için gerekli

class Program
{
    static void Main()
    {
        // 1. Aşama: 10 adet tam sayı verisi alacak bir dizi tanımla
        int[] sayilar = new int[10];

        // 2. Aşama: Diziyi bir for döngüsü ile doldur ve foreach döngüsü ile yazdır
        Console.WriteLine("Lütfen 10 adet tam sayı giriniz:");
        for (int i = 0; i < sayilar.Length; i++)
        {
            Console.Write($"Sayı {i + 1}: ");
            sayilar[i] = int.Parse(Console.ReadLine()); // Kullanıcıdan sayı al
        }

        Console.WriteLine("\nGirdiğiniz sayılar:");
        foreach (int sayi in sayilar)
        {
            Console.WriteLine(sayi);
        }

        // 3. Aşama: Kullanıcıdan yeni bir değer al ve 11. eleman olarak ekle
        Console.Write("\n11. sayıyı giriniz: ");
        int yeniSayi = int.Parse(Console.ReadLine());

        // Diziyi genişletmek için yeni bir dizi oluştur ve eski dizinin elemanlarını kopyala
        int[] yeniDizi = new int[sayilar.Length + 1];
        for (int i = 0; i < sayilar.Length; i++)
        {
            yeniDizi[i] = sayilar[i];
        }
        yeniDizi[yeniDizi.Length - 1] = yeniSayi; // 11. elemanı ekle

        // 4. Aşama: Diziyi büyükten küçüğe sırala ve ekrana yazdır
        Array.Sort(yeniDizi); // Küçükten büyüğe sırala
        Array.Reverse(yeniDizi); // Sıralamayı ters çevir

        Console.WriteLine("\nBüyükten küçüğe sıralı dizi:");
        foreach (int sayi in yeniDizi)
        {
            Console.WriteLine(sayi);
        }
    }
}