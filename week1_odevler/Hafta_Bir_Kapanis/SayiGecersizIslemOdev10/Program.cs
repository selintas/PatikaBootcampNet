// Console.ReadKey(); //cıktı dışındakı ıfadelerı görmuyoruz. Sadece merhaba dunya yazar.
// soru 10 :
//10. Kullanıcıdan iki sayı ve bir işlem (+, -, *, /) alın. Seçilen işleme göre sonucu hesaplayın ve yazdırın. Eğer geçersiz bir işlem girilirse "Geçersiz işlem" yazdırın.
int a, b;
string islem;

Console.Write("Sayı 1 : ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Sayı 2 : ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("İşlem (+, -, *, /): ");
islem = Console.ReadLine();

switch (islem)
{
    case "+":
        Console.WriteLine($"{a} {islem} {b} = {a + b}");
        break;
    case "-":
        Console.WriteLine($"{a} {islem} {b} = {a - b}");
        break;
    case "*":
        Console.WriteLine($"{a} {islem} {b} = {a * b}");
        break;
    case "/":
        Console.WriteLine($"{a} {islem} {b} = {a / b}");
        break;
    default:
        Console.WriteLine("Geçersiz İşlem");
        break;
}

Console.ReadKey();  