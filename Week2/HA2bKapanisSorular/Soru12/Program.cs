// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
#region yaklasım 1 dızıler ile  
/*
int EnBuyuk(params int[] dizi)
{
    return dizi.Max(); 
}
Console.WriteLine(EnBuyuk(48, 674, 99, -50, 9999));
Console.WriteLine(EnBuyuk(1, 3, 2);
Console.ReadKey();  
*/ 
#endregion 

#region Yaklasım 2 
int EnBuyugu()
{
    int sayac = 1;
    int sayi;
    bool sonuc = true; 
    int enBuyuk = int.MinValue; // 0 yazarsak - eksı degerlerı algılamaz. 
    while (sonuc)
    {
        Console.WriteLine($"Sayı {sayac++}: ");
        string cevap = Console.ReadLine(); 
        sonuc = int.TryParse( cevap, out sayi ); 
          
        if ( sonuc )
        {
            enBuyuk = Math.Max( enBuyuk, sayi ); // sayıların en buyugunu secıcek 
        }
    } 
    return enBuyuk;
}
#endregion 
int buyuk = EnBuyugu();
Console.WriteLine("En büyük sayı:" + buyuk);

Console.ReadKey();

