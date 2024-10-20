//7. ref Keyword
void Buyut(ref string ad)
{
    ad = ad.ToUpper();
}

string isim = "Hamit";
Buyut(ref isim);
Console.WriteLine(isim);

#region tersine cevir ornegı
void TersineCevir(ref string metin)
{
    if (string.IsNullOrEmpty(metin) || metin.Length == 1)
        return; //** dipnot oku


    string sonuc = "";

    for (int i = metin.Length - 1; i >= 0; i--)
    {
        char c = metin[i];
        sonuc += c;
    }
    metin = sonuc;

}
string x = "melis";
TersineCevir(ref x);
Console.WriteLine(x);

// dipnot : ref ile atanan degere herzaman borsey koymak zorunda degılsınız (ornek yukarıdakı  ıf kosulu)
#endregion

Console.ReadKey();