// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın. 

internal class Program
{
    private static void Main(string[] args)
    {
        //deger dondurmeyen metnı test et
        BenDegerDöndürmem();
        Console.ReadKey();
    }
    static void BenDegerDöndürmem() // static ekledık OPP konusu
    {
        Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");

    }

    
        
}