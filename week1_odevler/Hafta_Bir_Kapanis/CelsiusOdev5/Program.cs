// soru 5: 5. Kullanıcıdan bir sıcaklık değeri alın (Celsius cinsinden). Eğer sıcaklık 0'dan küçükse "Donuyor", 0 ile 30 arasında ise "Normal", 30'dan büyükse "Sıcak" yazdırın.
//bütün yöntemler ile.
Console.Write("Hava sıcaklığını Celsius cinsinden giriniz: ");
int sicaklik = Convert.ToInt32(Console.ReadLine()); // girdiğiniz string değeri integer cinsine çevirir.
#region Yöntem 1 uzun hali
if (sicaklik < 0)
{
    Console.WriteLine("Donuyor.");
}
else
{
    if (sicaklik <= 30)
    {
        Console.WriteLine("Normal"); 
    }
    else
    {
        Console.WriteLine("Sıcak");
    }

}
#endregion

#region Yöntem 2 if else kısa hali
if (sicaklik < 0)
{
    Console.WriteLine("Donuyor.");
}
else if (sicaklik <= 30)
    {
        Console.WriteLine("Normal");
    }
    else
    {
        Console.WriteLine("Sıcak");
    }
#endregion

#region Yöntem 3 {} daha kısa hali 
if (sicaklik < 0)
    Console.WriteLine("Donuyor.");

else if (sicaklik <= 30)
    Console.WriteLine("Normal");

else
    Console.WriteLine("Sıcak");
#endregion

#region Yöntem 4 en kısa hali try contıdıonal yolu

Console.WriteLine(sicaklik < 0 ? "Donuyor" : sicaklik > 30 ? "Sıcak" : "Normal");
#endregion
