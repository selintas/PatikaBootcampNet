using System;

class Program
{
    static void Main()
    {
        // Kullanıcıdan sayı alıyoruz
        Console.Write("Bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        // 10'a eşit mi, küçük mü, büyük mü kontrolü
        if (sayi == 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'a eşit.");
        }
        else if (sayi < 10)
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan küçük.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı 10'dan büyük.");
        }

        // Tek mi, çift mi kontrolü
        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girdiğiniz sayı çift.");
        }
        else
        {
            Console.WriteLine("Girdiğiniz sayı tek.");
        }
    }
}