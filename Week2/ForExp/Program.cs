//Pratik - For Örnekleri
//Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları for kullanarak yapınız.
#region odev 1
//1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

#endregion

#region odev 2
//2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
for (int i = 2; i < 20; i++)
    Console.Write(i + " ");
#endregion

#region odev 3
//3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
for (int i = 1; i < 20; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
#endregion

//crtl k s kısayol ile  region oluşturuldu.  
//baslık yaz. kodları saklar.
#region odev 4 
//4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0;

for (int i = 50; i <= 150; i++)
{
    toplam += i;  // i'yi toplam değişkenine ekle
}

Console.WriteLine(); // Bir satır boşluk bırak
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

#endregion

#region odev 5
//5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. 
int tekToplam = 0;
int ciftToplam = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0) // Çift sayı kontrolü
    {
        ciftToplam += i;
    }
    else // Tek sayı kontrolü
    {
        tekToplam += i;
    }
}
Console.WriteLine(); //satır boşluk bırak
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);

#endregion
Console.ReadKey();