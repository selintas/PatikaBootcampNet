// vıdeo lambda exp hafta 7 

// exp lambda tek ifade bir işlem tk satır kod ıfade eder.
// blok kodu ise statement lambda olur. 

//Delegate : metot işaretcisi motodu temsıl eder
// Func : geriye değer donduren 0-16 arasında parametre alır.
// son parametre değerı donus turunun parametresi olur.
// actıon : geriye değer dondurmez.
public class Program
{
    public static void Main(string[] args)
    {
        #region Func 
        //Func<int, int, int> divide = (x, y) =>
        //{
        //    if (y == 0)
        //        throw new DivideByZeroException("Bölen sıfır olamaz.");

        //    return x / y;
        //};
        //Console.WriteLine(divide(8,0));
        #endregion

        // cıft sayılar ıcın(func ornegı)
        //var numbers = new List<int>() { 1,2,3,4,5,6};
        //ProcessNumbers(numbers, n => n % 2 == 0); 

        // delegate ornegı
        Add add = (a, b) => a + b;
        Console.WriteLine(add(1,2));
        Console.WriteLine("_____");
        // func tanımla 
        Func<int,int,int> multiplay = (a, b) => a * b;
        Console.WriteLine(multiplay(2,5));
        Console.WriteLine("_______"); 
         
        Action<string> print = message => Console.WriteLine(message);
        print("Merhaba Action");
    }
    #region Delegate
    public delegate int Add(int x, int y);
    #endregion

    static void ProcessNumbers(List<int> numbers, Func<int, bool> filter)
    {
        foreach(var number in numbers)
        {
            if (filter(number)) 
            { Console.WriteLine(number); }
        }
    }
}