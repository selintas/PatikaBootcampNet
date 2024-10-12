// week 2 - Pratik - Yol Arkadaşı : Tatil uygulaması



bool devamEtmekIstiyorMu;

do
{
    devamEtmekIstiyorMu = false; // Her döngüde baştan kontrol etmesi için false'a ayarlanır.

    //başka attil yapmak istere döngü başa gider. 
    #region Lokasyon Seçimi
    // Lokasyon Seçimi için while uygulandı 
    string lokasyon = "";
    int lokasyonFiyati = 0;

    while (lokasyonFiyati == 0)
    {
        Console.WriteLine("Lütfen gitmek istediğiniz lokasyonu seçiniz (Bodrum, Marmaris, Çeşme):");
        lokasyon = Console.ReadLine().Trim().ToLower();

        if (lokasyon == "bodrum")
        {
            lokasyonFiyati = 4000;
        }
        else if (lokasyon == "marmaris")
        {
            lokasyonFiyati = 3000;
        }
        else if (lokasyon == "cesme" || lokasyon == "çeşme")
        {
            lokasyonFiyati = 5000;
        }
        else
        {
            Console.WriteLine("Hatalı bir lokasyon girdiniz. Lütfen Bodrum, Marmaris veya Çeşme olarak yeniden giriniz.");
        }
    }
    #endregion

    #region Kişi sayısı
    // Kişi Sayısı Seçimi 0 dan kücükse döngu devam eder kişi sayısı 0 dan buyuk olmalı
    int kisiSayisi = 0;
    while (kisiSayisi <= 0)
    {
        Console.WriteLine("Kaç kişi için tatil planlamak istiyorsunuz?");
        if (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0) // kişi sayısı 0 dan kucukse ve tryparse cevıremezse rakam degılse
        {
            Console.WriteLine("Geçerli bir kişi sayısı giriniz.");
        }
    }
    #endregion

    #region ulaşım seçimi
    // Ulaşım Seçimi
    int ulasimFiyati = 0;
    while (ulasimFiyati == 0)
    {
        Console.WriteLine("Tatilinize nasıl gitmek istersiniz? (1 yazarak Kara Yolu, 2 yazarak Hava Yolu seçeneğini seçiniz.)");
        Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım ücreti gidiş-dönüş 1500 TL)");
        Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım ücreti gidiş-dönüş 4000 TL)");

        string ulasimSecim = Console.ReadLine().Trim();

        switch (ulasimSecim) //  1 veya 2 secımı yapması için swich case kullanıldı.
        {
            case "1":
                ulasimFiyati = 1500;
                break;
            case "2":
                ulasimFiyati = 4000;
                break;
            default:
                Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen 1 ya da 2 seçeneğini giriniz.");
                break;
        }
    }
    #endregion
    #region ulaşım hesaplama

    // Toplam maliyet hesaplama
    int toplamFiyat = (lokasyonFiyati + (ulasimFiyati * kisiSayisi));
    Console.WriteLine();
    Console.WriteLine($"Tatiliniz için seçtiğiniz lokasyon: {lokasyon}");
    Console.WriteLine($"Kişi sayısı: {kisiSayisi}");
    Console.WriteLine($"Ulaşım şekli: {(ulasimFiyati == 1500 ? "1" : "2")}");
    Console.WriteLine($"Toplam tatil maliyetiniz: {toplamFiyat} TL");
    Console.WriteLine();

    #endregion

    #region başka tatil yapmak istiyormu 

    // Başka bir tatil planlamak isteyip istemediğini sorma
    string devam = "";
    do
{
    Console.WriteLine("Başka bir tatil planlamak ister misiniz? (Evet/Hayır)");
    devam = Console.ReadLine().Trim().ToLower();

    if (devam == "evet")
    {
        devamEtmekIstiyorMu = true; // Evet seçilirse döngü başa döner
    }
    else if (devam == "hayir")
    {
        devamEtmekIstiyorMu = false;
        Console.WriteLine("İyi günler! Tatil uygulamamızı kullandığınız için teşekkür ederiz.");
    }
    else
    {
        Console.WriteLine("Lütfen 'Evet' ya da 'Hayır' olarak yanıtlayınız.");
    }

} while (devam != "evet" && devam != "hayir"); // Geçerli cevap alana kadar sorar

        } while (devamEtmekIstiyorMu) ; // Başka tatil planlamak istenirse başa döner

    #endregion
 