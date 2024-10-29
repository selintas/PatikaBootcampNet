// dizilerle classız 

string[] adlar = { "Melis", "İlayda", "Ezgi", "Burak", "Mehmet Ali" };
int[] yaslar = { 23, 20, 27, 22, 28 };

Array.Sort(adlar); // adları alfabetik sıraya dizdi. 
 
for (int i = 0; i < adlar.Length; i++)
{
    Console.WriteLine($"{adlar[i]} {yaslar[i]} yasındadır."); // isimeler farklı sıralanınca yasların yerleri değişir.
} 
Console.ReadKey();  