using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

class Program
{
    static void Main(string[] args)
    {
        // Rastgele 10 adet sayıdan oluşan liste oluşturma
        //Random random = new Random();
        //List<int> numbers = Enumerable.Range(1, 10).Select(_ => random.Next(-50, 50)).ToList();
         
        Random random = new Random();
        List<int> numbers = new List<int>();
        for (int i = 0; i < 10; i++)
        {  
            numbers.Add(random.Next(-50,51));
        }
       

        // Listeyi konsola yazdır
        Console.WriteLine("Rastgele Sayılar: ");
        numbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n_____");

        // Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Çift Sayılar: ");
        //evenNumbers.ForEach(num => Console.Write(num + " ")); 
        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\n_____");

        // Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Tek Sayılar: ");
        oddNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n_____");

        // Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("Negatif Sayılar: ");
        negativeNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n_____");

        // Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine("Pozitif Sayılar: ");
        positiveNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n_____");

        // 15'ten büyük ve 22'den küçük sayılar
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: ");
        rangeNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n_____");

        // Listedeki her bir sayının karesi SELECT ile
        var squaredNumbers = numbers.Select(n => n * n).ToList(); //Select ile list elemanındakı belirli öz seçmek için list elemanı girer istenılen sonuc cıkar.(girdi alınır istenılen cıkar.)
        Console.WriteLine("Listedeki Sayıların Kareleri: ");
        //squaredNumbers.ForEach(num => Console.Write(num + " "));
        foreach (var number in squaredNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("\n_____");
    }
}


