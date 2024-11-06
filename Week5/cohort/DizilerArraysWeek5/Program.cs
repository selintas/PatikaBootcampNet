using System;

public class Program
{
    public static void Main()
    {
        // Bir dizi tanımlama ve elemanlarına erişme örneği

        // İnteger tipinde bir dizi tanımlama ve ilk değer atama
        int[] sayilar = new int[5]; // 5 elemanlık bir int dizisi oluşturuldu

        // Diziye değer atama
        sayilar[0] = 10;
        sayilar[1] = 20;
        sayilar[2] = 30;
        sayilar[3] = 40;
        sayilar[4] = 50;

        // Dizinin elemanlarına erişme ve ekrana yazdırma
        Console.WriteLine("Dizinin Elemanları:");
        Console.WriteLine(sayilar[0]); // 10
        Console.WriteLine(sayilar[1]); // 20
        Console.WriteLine(sayilar[2]); // 30
        Console.WriteLine(sayilar[3]); // 40
        Console.WriteLine(sayilar[4]); // 50

        // Dizi elemanlarının toplamını hesaplama örneği
        int toplam = 0;
        for (int i = 0; i < sayilar.Length; i++)
        {
            toplam += sayilar[i];
        }
        Console.WriteLine("Dizinin Elemanlarının Toplamı: " + toplam); // 150
    }
}

//Bu örnekte, int[] sayilar = new int[5];

//şeklinde bir dizi tanımladık ve 5 elemanlı bir int dizisi oluşturduk.
//Daha sonra bu diziye elemanlar atadık

//(sayilar[0] = 10;, sayilar[1] = 20;, vb.).
//
//Dizinin elemanlarına erişmek için indis numarasını kullanarak
//
//(sayilar[0], sayilar[1], vb.) değerleri ekrana yazdırdık.

//Ayrıca, sayilar.Length özelliğini kullanarak dizinin uzunluğunu alarak (yani içinde kaç eleman olduğunu) bir *for döngüsü* ile tüm elemanların toplamını hesapladık ve sonucu ekrana yazdırdık.

//Diziler, aynı türdeki verileri sıralı bir şekilde depolamamızı sağlayan ve C# dilinde sıkça kullanılan bir veri yapısıdır.