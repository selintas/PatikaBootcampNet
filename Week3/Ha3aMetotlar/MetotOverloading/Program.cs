//3.Method Overloading
//decimal Karesi(decimal sayi)
//double Karesi(double sayi)

// aynı class içinde veya skop içinde birden fazla metot tanımlamak için: ya değişken türü parametresi 3.3m gibi değişecek ya da parametre adedi türleri değişecek

namespace MetotOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Karesi(3.3m));
        } 
         
        static double Karesi(Double sayi) 
        {  
            return sayi * sayi; 
        }

        static decimal Karesi(decimal sayi)
        { 
            return sayi * sayi;
        
        }
    }
}
