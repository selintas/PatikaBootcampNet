// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
using System.ComponentModel;

void Degistir(ref string a, ref string b)
{
    string yedek = a; 
    a = b; 
    b = yedek;
}
Console.WriteLine("Ad 1: "); 
string ad1 = Console.ReadLine();

Console.WriteLine("Ad 2: ");
string ad2 = Console.ReadLine();

Console.WriteLine("Önce : {0} {1}", ad1, ad2);
Degistir(ref ad1, ref ad2); 
Console.WriteLine("Sonra: {0} {1}", ad1, ad2); 
 
Console.ReadKey();  
