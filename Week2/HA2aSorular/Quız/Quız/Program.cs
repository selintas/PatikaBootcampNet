//Quzı sorusu - turkıyenın baskentı neresıdır? 

Console.WriteLine("Türkiye'nin başkenti neresidir?");
Console.WriteLine("Cevap: "); 
string cevap = Console.ReadLine();

while (cevap.ToLower() != "ankara") // cevap ynalış oldukca devam eet ankara olmadıkca

{
    Console.WriteLine("Yanlış cevap :( Tekrar deneyiniz!"); 

    Console.Write("cevap: " + cevap); 
    //cevap = Console.ReadLine(); --> bunun yerine + cevap yazdım.
}
Console.WriteLine("Tebrikler! Doğru cevap :) ");
Console.ReadKey();
// doğru cevap yazılana (yani while ile cevap ankara olmadıgı sürece) while dongusu devam eder. 
// ToLower buyuk kucuk harf duyarlılıgını kaldırır. a veya A
