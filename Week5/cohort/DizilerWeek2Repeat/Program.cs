//diziler week 2 tekrar  
 
// diziler
 
//int sayi1 = 5; //[0] indek no
//int sayi2 = 10; //[1]
//int sayi3 = -5; //2
//int sayi4 = -111; //3 indeks no
//// Ram, stack, heap kavramları incele.

int[] sayilar = new int[4]; 
sayilar[0] = 5;
sayilar[1] = 10;
sayilar[2] = -5;
sayilar[3] = -111;
// dizi eleman syaısı uzunlugu 
Console.WriteLine("Dizi uzunlugu--->" + sayilar.Length);
Console.WriteLine("dizi ilk eleman" + sayilar[0]);
Console.WriteLine("son eleman" + sayilar[sayilar.Length-1]);

//for dongusu ile 
 
for (int i=0; i<sayilar.Length; i++)
{
    Console.WriteLine(sayilar[i]);
}

Console.WriteLine("------------String ile---------------");

string[] davetliler = new string[5];
for (int i=0; i<davetliler.Length; i++)
{
    Console.WriteLine("eklemek istediğin daverli ismi:"); 
    string davetli = Console.ReadLine();

    davetliler[i] = davetli;
}
Console.WriteLine("------- DAVETLİLER LİSTESİ ----"); 

for (int i=0;   i<davetliler.Length;  i++)
{
    Console.WriteLine(davetliler[i]);
}

// diziler 2. video


string[] kisiler = { "Ajda", "Funda", "Sezen" };  

for (int i=0;   i<kisiler.Length; i++)
{
    Console.WriteLine(kisiler[i]);
}
Console.WriteLine("----Foreach ile --------");

foreach (var item in kisiler) 
    {  
    Console.WriteLine(item);  
}
//foreach collectıon yapısı eleman sayısı kadar dongu calıstırır. her bır elemana item deersınız ne yazarsan onu yazdırırsın

Console.WriteLine("---------------");

int[] sayilar1 = new int[0];

while (true)
{
    Console.WriteLine("eklemek istediğin sayı gir: "); 
    int sayi1 = Convert.ToInt32(Console.ReadLine());

    Array.Resize(ref sayilar1, sayilar1.Length + 1);// array.resize dizinın yenı boytunu belirler. [ekledıgın sayı eklenır]
    sayilar1[sayilar1.Length - 1] =sayi1; // bu son sayını verır. 

    Console.WriteLine("Dongu cıkmak ıcın h, devam etmek için yenı bır karakter gır"); 
    char kontrol = Convert.ToChar(Console.ReadLine());

    if (kontrol == 'h')
        break;

}

// dizi ayzdır
Console.WriteLine("----- sayılar dızısı  yazdır ----"); 

foreach(var sayi1 in sayilar1)
{ Console.WriteLine(sayi1); }

// dizilerde sıralama sort.
Array.Sort(sayilar1); // sayılar dızısını kucukten buyuge sıraladı.
Array.Reverse(sayilar1); // diziyi ters cevırdı

Console.WriteLine("---BUYUKTEN KUCUGE SIRALAMA YAZDIR----");

foreach (var sayi1 in sayilar1)
{ Console.WriteLine(sayi1); } // foreach ıle tekrar yazdır.


