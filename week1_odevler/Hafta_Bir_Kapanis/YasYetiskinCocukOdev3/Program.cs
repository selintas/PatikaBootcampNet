// 3. Kullanıcıdan yaşını isteyin. Eğer yaş 18 veya daha büyükse "Yetişkinsiniz" yazdırın, aksi takdirde "Çocuksunuz" yazdırın.

Console.Write("Yaşınız: ");
int yas = Convert.ToInt32(Console.ReadLine());

#region Yöntem 1
// boolean ile ilk yöntem (true/false): 
bool buyukMu = yas >= 18;

if (buyukMu)
{
    Console.WriteLine("Yetişkinsiniz.");
}
else
{
    Console.WriteLine("Çocuksunuz.");
}
#endregion

#region Yöntem 2
if (yas >= 18)
    Console.WriteLine("Yetişkinsiniz.");
else
    Console.WriteLine("Çocuksunuz.");
#endregion

#region Yöntem 3
Console.WriteLine(yas < 18 ? "Çocukcusunuz." : "Yetişkinsiniz.");
// Ternary Conditional Operatör 
// şart ? doğruysa : yanlışsa
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
#endregion
   
//Bütün çözümler birlikte çalışır.
