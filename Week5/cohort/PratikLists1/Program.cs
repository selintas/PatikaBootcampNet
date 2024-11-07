// davetliler 

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List tanımlama
        List<string> davetliler = new List<string>();

        // Kullanıcıdan isimleri al
        Console.WriteLine("Lütfen davetli isimlerini giriniz. İşlemi sonlandırmak için boş bir isim giriniz.");

        while (true)
        {
            Console.Write("Eklemek istediğiniz davetli ismi: ");
            string davetli = Console.ReadLine();

            // Boş bir değer girildiğinde döngüden çık
            if (string.IsNullOrEmpty(davetli))
            {
                break;
            }

            // Listeye ismi ekle
            davetliler.Add(davetli);
        }

        // Davetli listesini yazdır
        Console.WriteLine("\n------- DAVETLİLER LİSTESİ -------");

        foreach (string isim in davetliler)
        {
            Console.WriteLine(isim);
        }
    }
}