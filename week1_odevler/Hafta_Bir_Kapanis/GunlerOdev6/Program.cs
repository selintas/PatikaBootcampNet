// soru 6 : 6. Kullanıcıdan 1 ile 7 arasında bir sayı alın. Bu sayı günlerden birini temsil ediyor. Sayıya göre "Pazartesi", "Salı", vb. gün adlarını yazdırın. Geçersiz bir sayı girildiğinde "Geçersiz gün" yazdırın.
Console.Write("Gün no giriniz: "); // haftanın hangi günü numarayla ifade ediniz.
int no = Convert.ToInt32(Console.ReadLine());

#region İsterseniz hata kontrolunu bastan da yapabilirsiniz, yorumdur.
//if (no < 1 || no > 7)
//{
//    Console.WriteLine("Geçersiz gün!");
//    Console.WriteLine("çıkmak için bir tuşa bas..");
//    Console.ReadKey();
//    Environment.Exit(0); // porgramdan çıkar kodlar çalışmaz. return yerıne yazılabılır.

//    //return;
//} not: Yoruma almak için: Ctrl + K + C yoruma almak için kullanıldı.

#endregion

#region Yöntem 1 ıf ile
if (no == 1)
    Console.Write("Pazartesi");
else if (no == 2)
    Console.Write("Salı");
else if (no == 3)
    Console.Write("Çarsamba");
else if (no == 4)
    Console.Write("Perşembe");
else if (no == 5)
    Console.Write("Cuma");
else if (no == 6)
    Console.Write("Cumartesi");
else if (no == 7)
    Console.Write("Pazar");
else
    Console.Write("Geçersiz gün!");

#endregion

#region Yöntem 2 swich cace ile
// yöntem 2 ctrl . ile convert to swich statement çevirildi.
switch (no)
{
    case 1:
        Console.Write("Pazartesi");
        break;
    case 2:
        Console.Write("Salı");
        break;
    case 3:
        Console.Write("Çarsamba");
        break;
    case 4:
        Console.Write("Perşembe");
        break;
    case 5:
        Console.Write("Cuma");
        break;
    case 6:
        Console.Write("Cumartesi");
        break;
    case 7:
        Console.Write("Pazar");
        break;
    default:
        Console.Write("Geçersiz gün!");
        break;
}
#endregion
Console.ReadKey(); 
