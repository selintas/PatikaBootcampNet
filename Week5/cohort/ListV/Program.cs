public class Program
{
    public static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 8,2,9,4,7};  

        List<string> fruits = new List<string>() { "elma", "Armut", "Muz"};

        numbers.Add(6);

        numbers.Insert(2, 10); // 2.ındekten sonra 10 ekle

       numbers.Remove(4); //4 u kaldır

        numbers.RemoveAt(4); // 4. ındeksı kaldır 

        numbers.Contains(3); // 3ü ara varsa true

        numbers.Clear();     // temızle

        numbers.Sort(); // sıralı listele.

        numbers.Reverse();  // ters cevır.

        //liste elemanlarını ddonmek foreach ile

        foreach(int i in numbers)
        {
            Console.WriteLine(i);
        }
         
        for(int i = 0; i < numbers.Count; i++)
        {
            Console.WriteLine(numbers[i]);
        }


    }
}
