//5 kişiden olusan bir kişi dizisi
using SıralamaHarmonisi;

Kisi[] kisiler =
{
    new Kisi() { Ad = "Melis", Yas = 23 },
    new Kisi() { Ad = "İlayda", Yas = 20 },
    new Kisi() { Ad = "Ezgi", Yas = 27 },
    new Kisi() { Ad = "Burak", Yas = 22 },
    new Kisi() { Ad = "Mehmet Ali", Yas = 28 },

};

foreach (Kisi k in kisiler.OrderBy(x => x.Yas)) // orderby sıralama yapıyor
{
    Console.WriteLine(k.Ozet());
}

Console.ReadKey();