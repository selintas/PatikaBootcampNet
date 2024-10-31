using CokBicimlilikPolymorphism;

class Program
{
    static void Main()
    {
        GeometricShape sekil1 = new Circle(); // GeometricShape türünde bir Circle nesnesi
        GeometricShape sekil2 = new Square(); // GeometricShape türünde bir Square nesnesi

        sekil1.Draw(); // Çıktı: Daire çizildi
        sekil2.Draw(); // Çıktı: Kare çizildi
    }
}