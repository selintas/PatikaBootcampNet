
using SınıflıSınıfsız;

Ogrenci o1 = new Ogrenci(); // ogrencı sınıfından o1 nesnesi oluşturuldu.
o1.Ad = "Burak";
o1.Yas = 23;
// buraya unvan gelmez private yaptık.
Ogrenci o2 = new Ogrenci() { Ad = "Serhat", Yas = 22 }; // diğer yazım şekli ile newnew oluşturma

o1.KunyeGoster();
o2.KunyeGoster();


#region Sınıfsız ornek
//string ad1 = "Burak";
//int yas1 = 23;
//string ad2 = "Serhat";
//int yas2 = 22;
//string kunye1 = $"{ad1} adlı kisi {yas1} yaşındadır.";
//string kunye2 = $"{ad2} adlı kisi {yas2} yasındadır.";
//Console.WriteLine(kunye1);
//Console.WriteLine(kunye2); 

//Console.ReadKey();  
#endregion