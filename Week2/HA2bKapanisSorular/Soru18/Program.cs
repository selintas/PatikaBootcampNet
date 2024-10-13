// 18 - " Selamlar " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak

//Trim(); bas sonu boşlukları sıler

using System.Net.Mime;

string metin = " Selamlar   ";
metin = metin.Trim();
Console.WriteLine(metin);

Console.ReadLine();
// string türü immutable bir turdur. hiçbir sting metodu o strıngı degıştıremez. :  yenı bır string üretip oonu dondurrur.
// Console.WriteLine(metin.Trim()); bu sekılde deısmez.
//https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/
//Immutability of strings