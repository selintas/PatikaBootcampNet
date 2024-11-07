using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // List tanımlama
        List<string> kahveler = new List<string>();

        // Program tanıtımı
        Console.WriteLine("Bir kahve içsek bize iyi gelecek!");

        // Kullanıcıdan kahve isimlerini al ve listeye ekle
        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"Kahve {i}: ");
            string kahve = Console.ReadLine();
            kahveler.Add(kahve);
        }

        // Kahve listesini ekrana yazdır
        Console.WriteLine("\n----- KAHVE LİSTESİ -----");
        for (int i = 0; i < kahveler.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {kahveler[i]}");
        }

        //int numara = 1;
        //foreach (string kahve in kahveler)
        //{
        //    Console.WriteLine($"{numara}. {kahve}");
        //    numara++;
        //}
    }
}