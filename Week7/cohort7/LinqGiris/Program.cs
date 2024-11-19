public class Program
{
    public static void Main(string[] args)
    {
       List<int> numbers = new List<int>() { 1,2,3,4,5};

        var evenNumbers = from number in numbers                 where number % 2 == 0                      select number; 

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("_____");
        var evenNumbers2 = numbers.Where(num => num % 2 == 0); 

        foreach (var number in evenNumbers)
        {
            Console.WriteLine(number);
        }

    }
}
