//Inheritance (miras alma)
//bir sınıfın başka bir sınıftan özelliklerini ve davranışlarını devralması anlamına gelir. Bu, kod tekrarını önlemeye ve sınıflar arasında hiyerarşik bir ilişki kurmaya yarar. 

using KalıtımMirasAlma_Inheritance_;

class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();

        myDog.Eat();   // Animal sınıfından miras alınan metod
        myDog.Sleep(); // Animal sınıfından miras alınan metod
        myDog.Bark();  // Dog sınıfının kendi metodudur

        Console.ReadLine();
    }
}