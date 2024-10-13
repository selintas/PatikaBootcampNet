//10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string Cevap(bool c)
{
    return c ? "Evet" : "Hayır"; 

}
Console.WriteLine("Benımle ^C# yazar mısın :  + Cevap(true)");
Console.WriteLine("Benımle kofte yer mısın: " +Cevap(false)); 
Console.ReadKey(); 
