// girilen sayının karesini alır   

int sayi;
bool sonuc;

do
{
    Console.Write("Sayı: "); 
    sonuc = int.TryParse(Console.ReadLine(), out sayi); // try.perse girilen degerı ınteger degere çevirir.

}while(!sonuc); // sonuc false ise tekrar calısır tryperse ceviremedıyse armut gıbı sayısal olmayan degerler ıcın.

Console.WriteLine("Sayının karesi: " + sayi * sayi);
Console.ReadKey();  

 
