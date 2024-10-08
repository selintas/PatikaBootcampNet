// soru 8: 8. Kullanıcıdan bir ay numarası (1-12) alın ve bu ayın kaç gün olduğunu yazdırın. Şubat ayı için 28 gün, diğer aylar için gün sayısını kontrol edin.
Console.WriteLine("Ay Numarası giriniz (1-12 kadar)");
int ay = Convert.ToInt32(Console.ReadLine());

int adet;

switch (ay)
{
    case 2:
        adet = 28;
        break;
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:  
    case 10:
    case 12:
        adet = 31;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        adet = 30;
        break;
    default:
        Console.WriteLine("Geçersiz bir ay no girdiniz.");
        Console.ReadKey();
        return;
}

Console.WriteLine("Ayın gün adedi : " + adet);
Console.ReadKey();


     

