// soru 7: 7. Kullanıcıdan bir not (0-100 arasında) alın. Notun aralığına göre "Başarılı", "Orta", "Başarısız" yazdırın. (0-60 başarısız, 61-80 orta, 81-100 başarılı)
using System.ComponentModel.Design;

baslangıc: // goto uygulamak için 
Console.Write("Notunuzu giriniz (1-100) : ");
int not = Convert.ToInt32(Console.ReadLine());

if  (not < 0 || not > 100)
    goto baslangıc; // 1-100 aralıgı dısında değer girilince tekrar ister. 
#region Yöntem 1 ıf else ile

string sonuc;

if (not > 80)
    sonuc = "Başarılı";
else if (not > 60)
    sonuc = "Orta";

else
    sonuc = "Başarısız";

Console.WriteLine("Sonuç: " + sonuc);

#endregion
#region Yöntem 2 
//turnery condıtıon ile 
Console.WriteLine("Sonuç: "
    + (not > 80 ? "Başarılı" : not > 60 ? "Orta" : "Başarısız"));

#endregion
Console.ReadKey(); 





