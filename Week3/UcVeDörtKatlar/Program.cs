// C# kodu, 1'den 50'ye kadar olan tam sayıları for döngüsü ile konsola yazdırır ve her sayının 3'e veya 4'e ya da hem 3'e hem de 4'e bölünüp bölünmediğini kontrol eder: 
// Program, 1'den 50'ye kadar olan tam sayıları for döngüsü ile console'a yazdıracağız. Bu sayıların her biri için aşağıdaki kurallara göre bir çıktı üretmelisiniz.

// Eğer sayı hem 3'ün hem de 4'ün katı ise, çıktı olarak "[sayı] hem 3'ün hem de 4'ün katıdır." şeklinde bir mesaj yazdırmalıdır.

// Eğer sayı yalnızca 3'ün katı ise, çıktı olarak "[sayı] 3'ün katıdır." şeklinde bir mesaj yazdırmalıdır.

// Eğer sayı yalnızca 4'ün katı ise, çıktı olarak "[sayı] 4'ün katıdır." şeklinde bir mesaj yazdırmalıdır.

using System;

class Program
{
    static void Main()
    {
        // 1'den 50'ye kadar olan sayılar için döngü
        for (int i = 1; i <= 50; i++)
        {
            // Hem 3'ün hem de 4'ün katı ise
            if (i % 3 == 0 && i % 4 == 0)
            {
                Console.WriteLine($"{i} hem 3'ün hem de 4'ün katıdır.");
            }
            // Sadece 3'ün katı ise
            else if (i % 3 == 0)
            {
                Console.WriteLine($"{i} 3'ün katıdır.");
            }
            // Sadece 4'ün katı ise
            else if (i % 4 == 0)
            {
                Console.WriteLine($"{i} 4'ün katıdır.");
            }
        }
    }
}


  

