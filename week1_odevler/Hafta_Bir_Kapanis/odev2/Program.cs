// 2. Kullanıcıdan iki tam sayı alın ve bu sayıların toplamını konsola yazdırın.
 
// 1. Sayıyı kullanıcıdan alıyoruz. Dönüştürme işlemını yapıyoruz (String - Integer).
Console.Write("Sayı 1: ");
string cevap1 = Console.ReadLine();
int sayi1 = Convert.ToInt32(cevap1);

Console.Write("Sayı 2: ");
string cevap2 = Console.ReadLine();
int sayi2 = Convert.ToInt32(cevap2); 
 
// ınteger cınsınden toplamı
int toplam = sayi1 + sayi2; 
Console.WriteLine("Toplam: " + toplam); 

Console.ReadKey();


