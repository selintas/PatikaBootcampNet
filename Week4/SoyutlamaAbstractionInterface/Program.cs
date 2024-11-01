using SoyutlamaAbstractionInterface;

class Program
{
    static void Main()
    {
        IShape sekil1 = new Circle(5); // IShape tipinde bir Circle nesnesi
        IShape sekil2 = new Square(4); // IShape tipinde bir Square nesnesi

        Console.WriteLine($"Dairenin alanı: {sekil1.CalculateArea()}"); // Çıktı: Dairenin alanı: 78.53981633974483
        Console.WriteLine($"Kare'nin alanı: {sekil2.CalculateArea()}"); // Çıktı: Kare'nin alanı: 16
    }
}