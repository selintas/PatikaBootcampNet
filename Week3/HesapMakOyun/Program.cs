// hesap makınesı

int sayi1, sayi2;
bool cevap1, cevap2;
string islem;
//Kullanıcıdan iki sayı al 
Console.WriteLine("Yapmak istediğiniz işlem için iki sayı gireceksiniz ...");


// Sayı 1 için doğru giriş yapana kadar döngü
do
{
    Console.Write("Sayı 1: ");
    cevap1 = int.TryParse(Console.ReadLine(), out sayi1);

    if (!cevap1)
    {
        Console.WriteLine("Geçersiz bir cevap girdiniz. Lütfen bir sayı giriniz...");
    }
} while (!cevap1); // cevap1 false olduğu sürece tekrar sorar

// Sayı 2 için doğru giriş yapana kadar döngü
do
{
    Console.Write("Sayı 2: ");
    cevap2 = int.TryParse(Console.ReadLine(), out sayi2);

    if (!cevap2)
    {
        Console.WriteLine("Geçersiz bir cevap girdiniz. Lütfen bir sayı giriniz...");
    }
} while (!cevap2); // cevap2 false olduğu sürece tekrar sorar

Console.WriteLine($"Girdiğin Sayılar: {sayi1} ve {sayi2}");


// İşlem seçiminde geçerli bir seçim yapana kadar döngü
do
{
    Console.WriteLine($"\r\nBu sayılarla hangi işlemi yapalım,seç bakalım. \r\nToplama için: + \r\nÇıkarma için: -\r\nÇarpma için: *\r\nBölme için: / \r\nyaz :) ");
    islem = Console.ReadLine();

    if (islem != "+" && islem != "-" && islem != "*" && islem != "/")
    {
        Console.WriteLine("Geçersiz İşlem. Lütfen +, -, * veya / giriniz.");
    }

} while (islem != "+" && islem != "-" && islem != "*" && islem != "/"); // Geçersiz işlem olduğu sürece tekrar sorar

switch (islem)
{
    case "+":
        Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 + sayi2}");
        break;
    case "-":
        Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 - sayi2}");
        break;
    case "*":
        Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 * sayi2}");
        break;
    case "/":
        // Sıfıra bölme kontrolü
        if (sayi2 == 0)
        {
            Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz! Elendin.");
        }
        else
        {
            Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 / sayi2}");
        }
        break;
}
Console.ReadKey();  