//Hafta 2 - Salı canlı ders soruları 1
//random zar atma 
Console.WriteLine("Zar atmak için bir tuşa basınız..");
Console.ReadKey(true);

Random rand = new Random();

baslangıc:

int zar = rand.Next(1, 7);
Console.WriteLine("\r\nGelen zar: " + zar);

Console.WriteLine("\r\nTekrar için E, çıkmak için başka bir tuşa basınız..");
ConsoleKey tus = Console.ReadKey(true).Key;

if (tus == ConsoleKey.E)
    goto baslangıc;

