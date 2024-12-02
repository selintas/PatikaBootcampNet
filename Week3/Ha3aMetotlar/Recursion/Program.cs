// 9. Recursion Faktorıyel metodu

// 0! = 1
// 5! =  1 * 2 * 3 * 4 * 5

#region Yontem 2 (Recursıon)  
// 5! = 4! * 5 
int FakRec(int n)
{
    // base case 
    if (n == 0 || n == 1)
            return 1; 

    return n * FakRec(n - 1);

}

Console.WriteLine($"5! = {FakRec(5)}");
#endregion

Console.WriteLine("------");

#region Yontem 1 (Recursıon kullanamdan)
int Fak1(int n)
{
    int Sonuc = 1;

    for (int i = 2; i <= n; i++)
        Sonuc *= i; // sonuc = sonuc * i

    return Sonuc;
}
Console.WriteLine($"5! = {Fak1(5)}");

#endregion