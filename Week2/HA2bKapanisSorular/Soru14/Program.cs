// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
//yontem 1 de
//bool CiftMi(int sayi) => sayi % 2 == 0;

//Console.WriteLine("Bir Sayı: ");
//int sayi = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(CiftMi(sayi) ? "çift" : "tek");

//yontem 2
bool CiftMi(int sayi)
{
    return sayi % 2 == 0;

} 

Console.WriteLine("Bir Sayı: ");
int sayi = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CiftMi(sayi) ? "çift" : "tek");

Console.ReadKey();