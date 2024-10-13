// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz. 

Console.WriteLine("Ad 1:");
string ad1 = Console.ReadLine();

Console.WriteLine("Ad 2:");
string ad2 = Console.ReadLine();

Console.WriteLine($"Değişimden önce: {ad1} ve {ad2}");
string yedek = ad1;
ad1 = ad2;
ad2 = yedek; // birinci isimden yedek oluşturup o ismi ikinci isme atadık.
Console.WriteLine($"Değişimden sonra: {ad1} ve {ad2}");

Console.ReadKey();  

