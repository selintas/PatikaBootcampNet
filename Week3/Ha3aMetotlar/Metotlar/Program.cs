//Metotlar
//Parametre Almayan Değer Döndürmeyen
void SaatiYazdır()
{
    Console.WriteLine(DateTime.Now.ToLongTimeString());
}
SaatiYazdır(); 
 

//Parametre Almayan Değer Döndüren 

int ZarAt()
{ 
    return new Random().Next(1, 7);
}
int zar = ZarAt();
Console.WriteLine("Gelen zar :" + zar);

//Parametre Alan Değer Döndürmeyen
 
void TekrarliYazdır(string metin, int kere)
{
    for (int i=0; i < kere; i++) 
        Console.WriteLine(metin);
}
TekrarliYazdır("Ankara'nın bağları", 7); // 7 kere yazar.


// Parametre Alan Değer Döndüren örneği
string Tersi(string metin)
{
    string sonuc = "";

    foreach (char c in metin)
    {
        sonuc = c + sonuc;
    }

    return sonuc;
}

string tersi = Tersi("gözde");
Console.WriteLine("Gözde'nin tersi: " + tersi);

// ---> for ile 


