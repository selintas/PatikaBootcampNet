// Week 2 - Metotlar Ek konusu - Pratik - İlk Metot Uygulamamız
//  4 adet metot tanımlama uygulaması 

using System;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        #region A DEĞER DONDURMEYEN METOT 
        // A. Değer döndürmeyen metodu çağırma 
        Greeting();
        #endregion CAGIRMA

        #region B DEĞER DONDUREN METOT CAGIRMA
        // B. Değer döndüren metodu çağırma
        // Rastgele sayıdan kalan değerini al
        int kalan = GetRandomNumberRemainder();
        Console.WriteLine("Üretilen rastgele sayının 2'ye bölümünden kalan: " + kalan);
        #endregion 

        #region C Parametre Alan ve Geriye Değer Döndüren Bir Metot CAGIRMA
        // İki sayıyı çarpan metodu çağırma 

        Console.WriteLine("1.SAYI:");
        int number1 = int.Parse(Console.ReadLine()); // İlk sayıyı al

        Console.WriteLine("2.SAYI:");
        int number2 = int.Parse(Console.ReadLine()); // İkinci sayıyı al

        // İki sayının çarpımını hesaplayan metodu çağırma
        int result = MultiplyNumbers(number1, number2);

        // Sonucu ekrana yazdırma
        Console.WriteLine($"{number1} ile {number2}'nin çarpımı: {result}");
        #endregion

        #region D Parametre Alan ve Geriye Değer Döndürmeyen bir Metotu CAGIRMA
        //Parametre Alan ve Geriye Değer Döndürmeyen bir Metotu cagırma
        //Parametre olarak isim ve soyisim bilgilerini alıp " Hoş Geldiniz {isim} {soyisim} " şeklinde ekrana bassın.
        
        Console.WriteLine("Lütfen isminizi giriniz:"); // Kullanıcıdan isim ve soyisim bilgilerini al
        string isim = Console.ReadLine();

        Console.WriteLine("Lütfen soyisminizi giriniz:");
        string soyisim = Console.ReadLine();

        // Hoş geldiniz mesajını yazdır
        WelcomeUser(isim, soyisim);

        #endregion
    }

    #region A.1. DEGER DONDURMEYEN METOT TANIMLAMA
    // A.1. Değer döndürmeyen bir metot tanımlama
    static void Greeting()
    {
        Console.WriteLine("Da Dumla Dumla Da");
    }
    #endregion

    #region B.1. DEĞER DONDUREN METOT TANIMLAMA
    // B.1. Değer döndüren bir metot tanımlama
    // Geriye tamsayı döndüren metot
    static int GetRandomNumberRemainder()
    {
        Random random = new Random(); // Random sınıfından bir örnek oluştur
        int randomNumber = random.Next(1, 10); // Rastgele bir sayı üret (0'dan int.MaxValue'a kadar)

        // 2'ye bölümünden kalanı hesapla
        int remainder = randomNumber % 2;

        return remainder; // Kalanı geri döndürür.
    }
    #endregion

    #region C.1. Parametre Alan ve Geriye Değer Döndüren Bir Metot TANIMLAMA
    // Parametre olarak iki tamsayı alan ve çarpımını geri döndüren metotu tanımlar
    static int MultiplyNumbers(int a, int b) // MultiplyNumbers: Metodun adıdır. Bu isim, metodu çağırırken kullanılır.
    {
        return a * b; // Çarpım sonucunu geri döndür
    }
    #endregion

    #region D.1. Parametre Alan ve Geriye Değer Döndürmeyen bir Metotu TANIMLAMA
    // Değer döndürmeyen bir metot
    static void WelcomeUser(string firstName, string lastName)
    {
        Console.WriteLine($"Hoş Geldiniz {firstName} {lastName}!");
    }
    #endregion
}