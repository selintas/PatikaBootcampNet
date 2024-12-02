//Sayı toplam

using System;

class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int toplam = Topla(n);

        Console.WriteLine($"1'den {n}'e kadar olan sayıların toplamı: {toplam}");
        Console.ReadKey();
    }
     
    // eksı oolamaz 
    
    static int Topla(int sayi)
    {
        if (sayi < 0) 
            throw new Exception("Sayı eksı olmaz.");  // exceptıon hata uyarısı
         

        if (sayi == 0 || sayi == 1) // 0 olduğunda toplam 0'dır
            return sayi;

        return sayi + Topla(sayi - 1); // Rekürsif çağrı
    }
}
