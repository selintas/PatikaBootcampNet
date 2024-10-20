//8. out Keyword
void DortIslem(double a, double b, out double toplam, out double fark, out double carpim, out double bolum)
{
    toplam = a + b;
    fark = a - b;
    carpim = a - b;
    bolum = a / b;

}
// nasıl kulanılır? 
//boş tabak hazırlnaır yanı içine değer atanmamış değişken 
double top, far, car, bol;

Console.WriteLine("a= ");
double s1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("b= ");
double s2 = Convert.ToDouble(Console.ReadLine());

DortIslem(s1, s2, out top, out far, out car, out bol);
Console.WriteLine("toplam: " + top);
Console.WriteLine("fark: " + far);
Console.WriteLine("carpımı: " + car);
Console.WriteLine("Bölüm: " + bol);
 
Console.ReadKey();  

