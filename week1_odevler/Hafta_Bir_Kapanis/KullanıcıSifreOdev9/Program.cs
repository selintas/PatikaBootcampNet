// 9. Kullanıcıdan bir şifre isteyin. Eğer şifre "12345" ise "Giriş Başarılı" yazdırın, değilse "Giriş Başarısız" yazdırın.

string sifre = "12345";
Console.WriteLine("Şifreyi giriniz: ");
string girilen = Console.ReadLine();

#region Yöntem 1 if else 
if (sifre == girilen)
    Console.WriteLine("Giriş Başarılı");
else
    Console.WriteLine("Giriş Başarısız");

#endregion

#region Yöntem 2 condıtıon operatıon
Console.WriteLine(sifre == girilen ? "Giriş Başarılı" : "Giriş Başarısız");
#endregion

#region Yöntem 3 swich case
switch (girilen)    
{
    case "12345":
        Console.WriteLine("Giriş Başarılı"); 
        break;
    default:
        Console.WriteLine("Giriş Başarısız");
        break;
}

#endregion