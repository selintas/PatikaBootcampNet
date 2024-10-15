// week3 - 3 seceneklı oyun  


Console.WriteLine("Proje haftasına hoş geldiniz! Hangi programı çalıştırmak istersiniz?");

string secim;

do
{
    // Seçenekler
    Console.WriteLine("\nAşağıdaki seçeneklerden birini seçin(1, 2, 3):");
    Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
    Console.WriteLine("2 - Hesap Makinesi");
    Console.WriteLine("3 - Ortalama Hesaplama");

    secim = Console.ReadLine();

    // Seçimi kontrol et ve uygun işlemi çağır
    switch (secim)
    {
        case "1":
            RastgeleSayiBulmaOyunu();
            break;
        case "2":
            HesapMakinesi();
            break;
        case "3":
            OrtalamaHesaplama();
            break;
        default:
            Console.WriteLine("Geçersiz bir seçim yaptınız. Lütfen tekrar deneyin.");
            break; // Geçersiz seçim durumunda döngü devam eder
    }

} while (true); // Herhangi bir geçersiz işlem yapıldığında döngü devam eder


void RastgeleSayiBulmaOyunu()
    {
        // Rastgele Sayı Bulma Oyunu

        //1. Rastgele bir sayı üretip , ekrana yazarız.
        Random rnd = new Random();
        int sayi = rnd.Next(1, 101); // 1-100 arasında

        Console.WriteLine("1-100 aralığında rastgele bir sayı(bu hocaya ve bana göstermek için): " + sayi); // bu random sayıyı ekrana yazdırır.


        int cevap;
        bool geçerliGiris;
        int tahminHakki = 5; // kullanıcının 5 canı var.

        //Kullanıcıya oyunu açıklıyor 
        Console.WriteLine("Ben rastgele bir sayı belirledim.Hadi sayıyı tahmin etmeye çalış! 1 ile 100 arasında olsun. ");

        // Kullanıcının 5 hakkı olduğu için tahmin döngüsünü başlatıyoruz
        while (tahminHakki > 0)
        {

            do //bir kere kullanıdan değer alıcaz do kullandım.
            {
                Console.WriteLine("Lütfen sayıyı tahmin ediniz: "); // Kullanıcıdan sayı tahmini alır
                string kullanıcıTahmin = Console.ReadLine();

                // Kullanıcı geçerli bir giriş mi yaptı, kontrol ediyor. int bir değer olacak.
                geçerliGiris = int.TryParse(kullanıcıTahmin, out cevap);

                if (!geçerliGiris)
                {
                    Console.WriteLine("Geçersiz bir giriş yaptınız. Lütfen bir sayı giriniz.");
                }

            } while (!geçerliGiris); // geçerli giriş yapılmadıkça tekrar sorar

            // Tahmini kontrol et
            if (cevap == sayi)
            {
                Console.WriteLine("Tebrikler! Doğru cevap :) ");
                break; // Doğru tahmin yapıldıysa döngüden çık
            }
            else
            {
                tahminHakki--; // Her yanlış tahminde hak 1 azalır ve gösteriyor.
                Console.WriteLine("Yanlış cevap. Kalan tahmin hakkınız: " + tahminHakki);

                if (tahminHakki == 0)
                {
                    Console.WriteLine($"Tahmin hakkınız bitti. Doğru cevap {sayi} idi.");
                }
                else if (cevap < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı girin.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı girin.");
                }

            }
        }
    }
    void HesapMakinesi()
    {
        // hesap makınesı

        int sayi1, sayi2;
        bool cevap1, cevap2;
        string islem;
        //Kullanıcıdan iki sayı al 
        Console.WriteLine("Yapmak istediğiniz işlem için iki sayı gireceksiniz ...");


        // Sayı 1 için doğru giriş yapana kadar döngü
        do
        {
            Console.Write("Sayı 1: ");
            cevap1 = int.TryParse(Console.ReadLine(), out sayi1);

            if (!cevap1)
            {
                Console.WriteLine("Geçersiz bir cevap girdiniz. Lütfen bir sayı giriniz...");
            }
        } while (!cevap1); // cevap1 false olduğu sürece tekrar sorar

        // Sayı 2 için doğru giriş yapana kadar döngü
        do
        {
            Console.Write("Sayı 2: ");
            cevap2 = int.TryParse(Console.ReadLine(), out sayi2);

            if (!cevap2)
            {
                Console.WriteLine("Geçersiz bir cevap girdiniz. Lütfen bir sayı giriniz...");
            }
        } while (!cevap2); // cevap2 false olduğu sürece tekrar sorar

        Console.WriteLine($"Girdiğin Sayılar: {sayi1} ve {sayi2}");


        // İşlem seçiminde geçerli bir seçim yapana kadar döngü
        do
        {
            Console.WriteLine($"\r\nBu sayılarla hangi işlemi yapalım,seç bakalım. \r\nToplama için: + \r\nÇıkarma için: -\r\nÇarpma için: *\r\nBölme için: / \r\nyaz :) ");
            islem = Console.ReadLine();

            if (islem != "+" && islem != "-" && islem != "*" && islem != "/")
            {
                Console.WriteLine("Geçersiz İşlem. Lütfen +, -, * veya / giriniz.");
            }

        } while (islem != "+" && islem != "-" && islem != "*" && islem != "/"); // Geçersiz işlem olduğu sürece tekrar sorar

        switch (islem)
        {
            case "+":
                Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 + sayi2}");
                break;
            case "-":
                Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 - sayi2}");
                break;
            case "*":
                Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 * sayi2}");
                break;
            case "/":
                // Sıfıra bölme kontrolü
                if (sayi2 == 0)
                {
                    Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz! Elendin.");
                }
                else
                {
                    Console.WriteLine($"{sayi1} {islem} {sayi2} = {sayi1 / sayi2}");
                }
                break;
        }

    }
    void OrtalamaHesaplama()
    {
        // Not Ortalaması Hesaplama


        double not1, not2, not3;

        // Kullanıcıdan notları al
        Console.Write("Birinci ders notunuzu giriniz: ");
        not1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci ders notunuzu giriniz: ");
        not2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Üçüncü ders notunuzu giriniz: ");
        not3 = Convert.ToDouble(Console.ReadLine());

        // Notların geçerli olup olmadığını kontrol et (0-100 aralığında)
        if (not1 < 0 || not1 > 100 || not2 < 0 || not2 > 100 || not3 < 0 || not3 > 100)
        {
            Console.WriteLine("Geçersiz bir not girdiniz. Notlar 0 ile 100 arasında olmalıdır.");
            return; // Programı sonlandır
        }

        // Ortalamayı hesapla
        double ortalama = (not1 + not2 + not3) / 3;
        Console.WriteLine($"Ortalamanız: {ortalama}");

        // Harf notunu belirle ve ekrana yazdır
        string harfNotu;

        if (ortalama >= 90)
            harfNotu = "AA";
        else if (ortalama >= 85)
            harfNotu = "BA";
        else if (ortalama >= 80)
            harfNotu = "BB";
        else if (ortalama >= 75)
            harfNotu = "CB";
        else if (ortalama >= 70)
            harfNotu = "CC";
        else if (ortalama >= 65)
            harfNotu = "DC";
        else if (ortalama >= 60)
            harfNotu = "DD";
        else if (ortalama >= 55)
            harfNotu = "FD";
        else
            harfNotu = "FF";

        Console.WriteLine($"Harf Notunuz: {harfNotu}");

        
    }
    Console.ReadKey();


    