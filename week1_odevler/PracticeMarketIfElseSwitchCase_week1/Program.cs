using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to Ruya Market!");
        Console.WriteLine("\nApple = 2 TL\nPear = 3 TL\nStrawberry = 2 TL\nBanana = 3 TL\nAll other fruits = 4 TL\n");
        Console.WriteLine("Which fruit would you like to buy? (apple, pear, strawberry, banana): ");
        string fruit = Console.ReadLine().ToLower(); // Harf duyarlılığını ortadan kaldırmak için küçük harfe çeviriyoruz.

        switch (fruit)
        {
            case "apple":
                Console.WriteLine("Apple = 2 TL");
                break;
            case "pear":
                Console.WriteLine("Pear = 3 TL");
                break;
            case "strawberry":
                Console.WriteLine("Strawberry = 2 TL");
                break;
            case "banana":
                Console.WriteLine("Banana = 3 TL");
                break;
            default:
                Console.WriteLine("All other fruits = 4 TL");
                break;
        }
    }
}// When comparing If-Else and Switch-Case structures, it is often more appropriate to use "Switch-Case" for solving such problems. 
 // This is because Switch-Case provides a more readable and organized structure when dealing with many conditions. 
 // Additionally, Switch-Case can be faster in terms of performance, as the compiler can branch based on a specific constant value. 
 // The If-Else structure can become complex and difficult to read when there are numerous conditions. 
 // However, Switch-Case is limited to checking only constant values, making it more restrictive.