//  C# dilinde Dictionary<TKey, TValue> koleksiyonu, anahtar-değer çiftleri şeklinde veri saklamak için kullanılan çok kullanışlı bir koleksiyon türüdür.
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary tanımlama
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Anahtar-değer çiftleri ekleme
        ages["Alice"] = 30; // sol key = value sağ 
        ages["Bob"] = 25;
        ages["Charlie"] = 35;

        // Bir anahtarın değerini alma
        Console.WriteLine("Alice's age: " + ages["Alice"]);

        // Dictionary üzerinde döngü ile gezinme
        foreach (var person in ages)
        {
            Console.WriteLine($"Name: {person.Key}, Age: {person.Value}");
        }

        // Bir anahtarı kontrol etme
        if (ages.ContainsKey("Alice"))
        {
            Console.WriteLine("Alice is in the dictionary.");
        }

        // Bir anahtarı silme
        ages.Remove("Bob");

        // Dictionary'nin güncel durumu
        Console.WriteLine("Updated dictionary:");
        foreach (var person in ages)
        {
            Console.WriteLine($"Name: {person.Key}, Age: {person.Value}");
        }
    }
}
