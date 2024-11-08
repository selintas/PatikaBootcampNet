//// generic collectıons 

//Dictionary<int, string> students = new Dictionary<int, string>();  
////dictoınary<Tkey,TValue>

//students.Add(1, "Ali");
//students.Add(2, "Ayşe");

//string student = students[1]; // 1 numaralı öğrenciyi aldı key degerı 1

//Console.WriteLine(student);

//if (!students.ContainsKey(2)) // contaınskey varmı yokmu kontrol eder
//{
//    students.Add(2, "Veli");
//}
//else
//{
//    students.Add(3, "Veli");

//}

//Console.WriteLine(students[2]);  // [2] numara yazdır.
 
//Console.WriteLine(students[3]);

//// çıkarmak 
//students.Remove(1); 

//if(!students.ContainsKey(1))
//{
//    students.Add(1, "Mehmet"); 

//}
//Console.WriteLine("___");

//Console.WriteLine(students[1]);

//// verilerin eklemık cımkası için kullanılır 
///

Dictionary<string, string> capitals = new Dictionary<string, string>()
{
    {"Türkiye" , "Ankara" },
    {"Almanya" , "Berlin" },
    {"Fransa" , "Paris" }

};
// yenı bır ulke ekle 
capitals.Add("İtalya", "Roma");

string capitalOfGermany = capitals["Almanya"];

Console.WriteLine($"almanya başkenti: {capitalOfGermany}");

if (capitals.ContainsKey("Fransa"))
{
    capitals.Remove("Fransa");
    Console.WriteLine("Fransa başkent bilgisi kaldırıldı");
} 
foreach (KeyValuePair<string,string> kvp in capitals) // keyvalurpair 2 tane deger atar. like string,string
{
    Console.WriteLine($"ülke {kvp.Key} başkent ise {kvp.Value}");
}