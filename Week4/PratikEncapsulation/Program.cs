using PratikEncapsulation;

class Program
{
    static void Main(string[] args)
    {
        // Geçerli kapı sayısı ile nesne oluşturma
        Araba araba1 = new Araba { Marka = "Toyota", Model = "Corolla", Renk = "Gri", KapiSayisi = 4 };
        araba1.ArabaBilgileri();

        // Geçersiz kapı sayısı ile nesne oluşturma
        Araba araba2 = new Araba { Marka = "Honda", Model = "Civic", Renk = "Beyaz", KapiSayisi = 3 };
        araba2.ArabaBilgileri();
    }
}
