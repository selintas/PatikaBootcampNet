// 1-20 aralıpındaki sayıları yazdır 
//3ün ve 5 in katları hariç 

#region Yontem 1  
for (int i = 1; i <= 20; i++)
{ 
    if (i % 3 != 0 && i % 5 != 0)   
    Console.Write(i + " ");
}
#endregion
Console.WriteLine("\r\n\r\n_____________________________\r\n");
#region Yontem 2 
for (int i = 1; i <= 20; i++)
{
    if (i % 3 == 0 || i % 5 == 0) 
        continue; // 3 ve 5 ın katı gelince atlar tekrar yazar. || bu ve dır

    Console.Write(i + " ");
}
#endregion
Console.ReadKey();

