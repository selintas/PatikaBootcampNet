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

        int numara = 1;
        foreach (string isim in davetliler)
        {
            Console.WriteLine($"{numara}. {isim}");
            numara++;
        }
    }
}

//﻿using System;
//using System.Collections.Generic;

//class Program
//{
//    static void Main()
//    {
//        // Ziyaretçilerin isimlerini içeren bir liste tanımlayın
//        List<string> ziyaretciler = new List<string>()
//        {
//            "1.Bülent Ersoy",
//            "2.Ajda Pekkan",
//            "3.Ebru Gündeş",
//            "4.Hadise",
//            "5.Hande Yener",
//            "6.Tarkan",
//            "7.Funda Arar",
//            "8.Demet Akalın"
//        };

//        // İsimleri tek tek ekrana yazdır
//        Console.WriteLine("Ziyaretçi Listesi:");

//        foreach (string isim in ziyaretciler)
//        {
//            Console.WriteLine(isim);
//        }
//    }
//}