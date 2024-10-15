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

Console.ReadKey();  