//bırbırıne yaklasan sayılar 2 sayı alıcaz bırı azalıcak  bırı artacak
//10 20 gibi  

Console.Write("Sayı 1: "); 
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Sayı 2: "); 
int sayi2 = Convert.ToInt32(Console.ReadLine());

for (int i = sayi1, j = sayi2; i <= j; i++, j--)
{
    Console.WriteLine($"{i} {j}");
}
Console.ReadKey();  