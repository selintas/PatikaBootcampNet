// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.

double DaireAlan(double yariCap)
{
    return Math.PI * yariCap * yariCap;
}
Console.WriteLine("Yarıçap: ");
double r = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Alan: " + DaireAlan(r));

Console.ReadKey();