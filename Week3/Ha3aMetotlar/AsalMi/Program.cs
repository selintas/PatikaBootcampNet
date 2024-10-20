// 2. Metotlarda return Keyword'ünü Etkili Kullanma 
// asal sayı: 1 ve kendınden başka sayıya bölünmeyen 
// en küçük asal sayı 2 dir.

bool AsalMi(int sayi)
{
    for (int i = 2; i < sayi; i++) //2 den başlıyor.
    {
        if (sayi % i == 0)
            return false; // asal değildir bölerse
    } 
    return true; // asal bölemezse
}
Console.WriteLine("Sayı giriniz: "); 
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AsalMi(sayi) ? "Asal" : "Asal Değil"); // sayı ? true : false 

// bir sayının bölenı varsa karekokune kadar böler 
#region yontem 2 karekok ile  

bool AsalMi2(int sayi1)
{
    for (int i = 2; i <= Math.Sqrt(sayi1); i++) //krekoku ile
    {
        Console.WriteLine("BÖLÜYOR" + i + "SAYISINA..");
        if (sayi1 % i == 0)
            return false; // asal değildir bölerse
    }
    return true; // asal bölemezse
}
Console.WriteLine("Sayı giriniz: ");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(AsalMi2(sayi1) ? "Asal" : "Asal Değil"); // sayı ? true : false 

#endregion
Console.ReadKey();  

