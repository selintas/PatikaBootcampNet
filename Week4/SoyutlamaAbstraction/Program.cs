using SoyutlamaAbstraction;
class Program
{
    static void Main()
    {
        Animal hayvan1 = new Dog { Name = "Fido" };
        Animal hayvan2 = new Cat { Name = "Minka" };

        hayvan1.PrintInfo(); // Çıktı: Bu hayvanın adı: Fido
        hayvan1.MakeSound(); // Çıktı: Hav! Hav!

        hayvan2.PrintInfo(); // Çıktı: Bu hayvanın adı: Minka
        hayvan2.MakeSound(); // Çıktı: Miyav!
    }
}