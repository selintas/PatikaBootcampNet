using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Rastgele 10 adet sayıdan oluşan liste oluşturma
        Random random = new Random();
        List<int> numbers = Enumerable.Range(1, 10).Select(_ => random.Next(-50, 50)).ToList();

        // Listeyi konsola yazdır
        Console.WriteLine("Rastgele Sayılar: ");
        numbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n");

        // Çift olan sayılar
        var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Çift Sayılar: ");
        evenNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n");

        // Tek olan sayılar
        var oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
        Console.WriteLine("Tek Sayılar: ");
        oddNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n");

        // Negatif sayılar
        var negativeNumbers = numbers.Where(n => n < 0).ToList();
        Console.WriteLine("Negatif Sayılar: ");
        negativeNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n");

        // Pozitif sayılar
        var positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine("Pozitif Sayılar: ");
        positiveNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n");

        // 15'ten büyük ve 22'den küçük sayılar
        var rangeNumbers = numbers.Where(n => n > 15 && n < 22).ToList();
        Console.WriteLine("15'ten Büyük ve 22'den Küçük Sayılar: ");
        rangeNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n");

        // Listedeki her bir sayının karesi
        var squaredNumbers = numbers.Select(n => n * n).ToList();
        Console.WriteLine("Listedeki Sayıların Kareleri: ");
        squaredNumbers.ForEach(num => Console.Write(num + " "));
        Console.WriteLine("\n");
    }
}


