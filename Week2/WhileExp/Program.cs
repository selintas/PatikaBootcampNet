// week 2 - Pratik - While Örnekleri
// Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları while kullanarak yapınız.

#region odev 1
// 1 -> Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++; // Her seferinde i'yi 1 artırıyoruz
}
Console.WriteLine(); // Satır boşluğu için 
#endregion

#region odev 2
// 2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
int y = 1;

while (y <= 20)
{
    Console.Write(y + " ");
    y++; // y'yi her döngüde 1 artırıyoruz
}
Console.WriteLine(); // Satır boşluğu
#endregion

#region odev 3
// 3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
int z = 1;

while (z <= 20)
{
    if (z % 2 == 0) // z'nin çift olup olmadığını kontrol et
    {
        Console.Write(z + " "); // Çift sayıyı yazdır 
    }
    z++; // z'yi her döngüde 1 artırıyoruz
}
Console.WriteLine(); // Satır boşluğu
#endregion

#region odev 4
// 4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
int toplam = 0; // Toplamı saklamak için bir değişken
int x = 50; // Başlangıç değeri

while (x <= 150)
{
    toplam += x; // x'i toplam değişkenine ekle
    x++; // x'i her döngüde 1 artır
}
Console.WriteLine(); // Satır boşluğu için 
Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);
#endregion

#region odev 5
// 5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız. 
int tekToplam = 0; // Tek sayıların toplamı için değişken
int ciftToplam = 0; // Çift sayıların toplamı için değişken
int j = 1; // Başlangıç değeri

while (j <= 120)
{
    if (j % 2 == 0) // Çift sayı kontrolü
    {
        ciftToplam += j; // Çift sayıyı toplam değişkenine ekle
    }
    else // Tek sayı kontrolü
    {
        tekToplam += j; // Tek sayıyı toplam değişkenine ekle
    }
    j++; // j'yi her döngüde 1 artır
}

// Toplamları döngü tamamlandıktan sonra yazdır
Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı: " + tekToplam);
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı: " + ciftToplam);
#endregion