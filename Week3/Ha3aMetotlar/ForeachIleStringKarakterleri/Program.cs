// Foreach ile tek tek karakterleri al ekrana sırayla satır satır yazar.
//tersine dondurecegız bunu kullanrak   
// foreach örnek

string ad = "berkan"; 
 
foreach(char c in ad)
{
    Console.WriteLine(c);
}
Console.WriteLine("-----------------------"); 
//for ile ,
for(int i = 0; i < ad.Length; i++)
{
    Console.WriteLine(ad[i]);
}
Console.ReadKey();

