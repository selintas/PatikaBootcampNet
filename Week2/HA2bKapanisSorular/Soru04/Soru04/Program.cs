// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.

#region yontem 1 rastgele sayıyı gostererek

int sayi = new Random().Next(100);
Console.WriteLine("Rastgele sayı: {0}\r\nBu sayının üçe bölümünden kalan: {1}", sayi, sayi % 3);
#endregion
Console.WriteLine("___"); 

#region yontem tek satır  

// rastgele sayıyı gostermez kalanı verır
Console.WriteLine("Rastlege sayının üce bölumunden kalanı: " + new Random().Next(100) % 3); //(100) demek 0 dan 100 ekadar
#endregion


/*Random sayı üretme Formulu
 
Random rnd = new Random();
int sayi = rnd.Next(1, 101);
Console.WriteLine("1-100 aralığında rastgele sayı" + sayi);

*/
Console.ReadKey();
