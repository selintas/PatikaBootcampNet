// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız
// x = V.t

double AlinanYol(double hız, double sure)
{
    return hız * sure;
}
Console.WriteLine("saatteki hızı 100km/sa olan bır arac 3 saatte nekadar yol gider? ");
Console.WriteLine(AlinanYol(100, 3) + "km");
 
Console.ReadKey(); 