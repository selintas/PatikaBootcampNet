// 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random rnd = new Random();

int sayi  = rnd.Next(1, 101); // 101 dn kucuk sayıyı ilafe eder bır altı yani 100 yazabılır 101 yazamaz.
                             
Console.WriteLine("1-100 aralığında rastgele bir sayı: " +sayi);    
Console.ReadKey();  