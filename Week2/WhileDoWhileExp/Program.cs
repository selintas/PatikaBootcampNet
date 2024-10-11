//Pratik - While vs Do-While Farkı

#region While Yöntem 1

Console.WriteLine("Bir limit değeri giriniz:");
int limit = int.Parse(Console.ReadLine()); // Kullanıcıdan limit değeri alıyoruz

int sayac = 0;

while (sayac <= limit)
{
    Console.WriteLine(sayac + " - Ben bir Patika'lıyım");
    sayac++; // Sayaç her seferinde 1 artırılır
}

Console.WriteLine("While döngüsü sona erdi.");
#endregion

#region Do-While Yöntem
Console.WriteLine("Bir başka limit değeri giriniz:");
int limit2 = int.Parse(Console.ReadLine()); // Kullanıcıdan limit değeri alıyoruz

int sayac2 = 0;

do
{
    Console.WriteLine(sayac2 + " - Ben bir Patika'lıyım");
    sayac2++; // Sayaç her seferinde 1 artırılır
}
while (sayac2 <= limit2);

Console.WriteLine("Do-While döngüsü sona erdi.");
#endregion


/*
    While Döngüsü ve Do-While Döngüsü Arasındaki Farklar:

    1. While Döngüsü:
       - Koşul, döngü bloğuna girilmeden önce kontrol edilir.
       - Eğer koşul başta sağlanmazsa, döngü hiç çalışmaz.
       - Örnek: Eğer kullanıcı `limit` olarak negatif bir değer girerse, döngü hiç çalışmaz.

    2. Do-While Döngüsü:
       - Koşul, döngü bloğu çalıştıktan sonra kontrol edilir.
       - Bu nedenle döngü, en az bir kez mutlaka çalışır.
       - Örnek: Eğer kullanıcı `limit2` olarak negatif bir değer girse bile, döngü bloğu en az bir kez çalışır ve ekrana bir çıktı verir.

    Sonuç olarak:
    - While döngüsü başta koşulu kontrol eder ve şart sağlanmazsa hiç çalışmaz.
    - Do-While döngüsü ise şart sağlanmasa bile en az bir kez döngüyü çalıştırır.
*/
