// soru 4 : 4.Kullanıcıdan bir tam sayı alın. Eğer sayı çift ise "Çift sayıdır" yazdırın, tek ise "Tek sayıdır" yazdırın.
soru:
Console.Write("Bir sayı giriniz:"); 
string cevap = Console.ReadLine();
int sayi; 
bool basariliMi = int.TryParse(cevap, out sayi); 
// tryparse yontemı girilen string ifadenın int olup olmadıgını kontrol eder. karpuz yazarsanız olmayacaktır. 
if (!basariliMi)
{
    Console.WriteLine("Geçersiz bir ifade girdiniz!");
    Console.WriteLine("Lütfen tekrar giriniz.");
    goto soru; // if basarılı değilse başa göner soru ıfadesınden tekrar baslar. 
}

#region Yöntem 1
if (sayi % 2 == 0)
    Console.WriteLine("Çift Sayıdır."); 
else
    Console.WriteLine("Tek sayıdır.");
#endregion 
Console.ReadKey();

#region Yöntem 2
string sonuc = sayi % 2 == 0 ? "Çift" : "Tek";
Console.WriteLine(sonuc + " sayıdır.");

//Console.WriteLine((sayi % 2 == 0 ? "Çift" : "Tek") + " sayıdır.");
// bu sekılde kısa yazımı yapılabılır.
#endregion
