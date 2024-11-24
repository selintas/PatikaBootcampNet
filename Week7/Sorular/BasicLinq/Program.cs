// Basit LINQ Sorguları

//(1) Bir liste içerisindeki çift sayıları filtreleyen bir LINQ sorgusu yazın. 

using System.ComponentModel;

List<int> sayılar1 = new List<int>() { 1, 5, 3, 8, 6, 4, 2, 9, 7, 10 };

var cs = sayılar1.Where(x => x % 2 == 0);
//Count(): Bu metot, filtrelenmiş çift sayıların toplam sayısını döner. 

// joın strıng ıle kulllanılır.

Console.WriteLine("Çift Sayılar: " + string.Join(" ", cs));

int toplam = cs.Count(); // cıft sayı toplamı count ıle  
Console.WriteLine("Çift sayıların toplamı: " + toplam);

Console.WriteLine("---");

//(2) Bir string listesindeki sadece 5 harften uzun olan kelimeleri seçin. 
List<string> isimler = new List<string>()  
{  
     "Mohammed",
     "Muzaffer", 
     "Hüsniye", 
     "Selin", 
     "Rukiye",
     "Ömercik"
};

var sonuc1 = isimler.Where(ad => ad.Length > 5).ToList(); 

Console.WriteLine("5 harften uzun isimler : " + string.Join(" ",sonuc1));

Console.WriteLine("---");

// (3) Bir tamsayı listesinde en büyük sayıyı bulan bir LINQ sorgusu yazın. (1)de sayılar1 list kullanıldı. 

Console.WriteLine("list sayilar1 en büyük sayısı: " + sayılar1.Max());
Console.WriteLine("--");

// (4) Bir liste içerisindeki sayıları artan sırayla sıralayın. ordeyby ile 
var sıralıSayılar = sayılar1.OrderBy(x => x).ToList();

Console.WriteLine("Sırasıyla sayılar1 list: " + string.Join(" - ", sıralıSayılar));
Console.WriteLine("---"); 

// (5) Bir liste içerisindeki sayıların karesini alan bir LINQ sorgusu yazın. 
var karesiTopla = sayılar1.Select(y => Math.Pow(y, 2)).Sum();
Console.WriteLine("Sayıların karesi toplamı : ");
Console.Write(string.Join("", karesiTopla));


Console.ReadKey();