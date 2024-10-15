// Rastgele Sayı Bulma Oyunu

//1. Rastgele bir sayı üretip , ekrana yazarız.
Random rnd = new Random();
int sayi = rnd.Next(1, 101); // 1-100 arasında

Console.WriteLine("1-100 aralığında rastgele bir sayı(bu hocaya ve bana göstermek için): " + sayi); // bu random sayıyı ekrana yazdırır.


int cevap;
bool geçerliGiris;
int tahminHakki = 5; // kullanıcının 5 canı var.

//Kullanıcıya oyunu açıklıyor 
Console.WriteLine("Ben rastgele bir sayı belirledim.Hadi sayıyı tahmin etmeye çalış! 1 ile 100 arasında olsun. ");

// Kullanıcının 5 hakkı olduğu için tahmin döngüsünü başlatıyoruz
while (tahminHakki > 0)
{

    do //bir kere kullanıdan değer alıcaz do kullandım.
    {
        Console.WriteLine("Lütfen sayıyı tahmin ediniz: "); // Kullanıcıdan sayı tahmini alır
        string kullanıcıTahmin = Console.ReadLine();

        // Kullanıcı geçerli bir giriş mi yaptı, kontrol ediyor. int bir değer olacak.
        geçerliGiris = int.TryParse(kullanıcıTahmin, out cevap);

        if (!geçerliGiris)
        {
            Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen bir sayı giriniz.");
        }

    } while (!geçerliGiris); // geçerli giriş yapılmadıkça tekrar sorar

    // Tahmini kontrol et
    if (cevap == sayi)
    {
        Console.WriteLine("Tebrikler! Doğru cevap :) ");
        break; // Doğru tahmin yapıldıysa döngüden çık
    }
    else
    {
        tahminHakki--; // Her yanlış tahminde hak 1 azalır ve gösteriyor.
        Console.WriteLine("Yanlış cevap. Kalan tahmin hakkınız: " + tahminHakki);

        if (tahminHakki == 0)
        {
            Console.WriteLine($"Tahmin hakkınız bitti. Doğru cevap {sayi} idi.");
        }
        else if (cevap < sayi)
        {
        Console.WriteLine("Daha büyük bir sayı girin.");
        }
        else
        {
        Console.WriteLine("Daha küçük bir sayı girin.");
        }
        
    }
}

Console.ReadKey();

