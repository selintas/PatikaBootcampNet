// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
int yas;

Console.WriteLine("Yaşınız: ");
yas =Convert.ToInt32(Console.ReadLine());
// Koşul ? dogruysa : yaslışsa
Console.WriteLine(yas >= 18 ? "+" : "-");  

Console.ReadKey();
