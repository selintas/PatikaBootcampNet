CH6 - Canlı Ders 3a 

1. Metot Çeşitleri
Parametre Almayan Değer Döndürmeyen
void SaatiYazdir()
1. 
Parametre Almayan Değer Döndüren
int ZarAt()

Parametre Alan Değer Döndürmeyen
void TekrarliYazdir(string metin, int kere)

Parametre Alan Değer Döndüren
string Tersi(string metin)

2. Metotlarda return Keyword'ünü Etkili Kullanma
bool AsalMi(int sayi)

3. Method Overloading
decimal Karesi(decimal sayi)
double Karesi(double sayi)

4. Named Arguments
- Math.Pow örneği

5. Optional Arguments
void SaatiYazdir(bool saniyeGizle = false)

6. Named and Optional Arguments
void Yazdir(string metin, int adet = 1, bool buyult = false, bool ortala = false)

7. ref Keyword
void TersineCevir(ref string metin)

8. out Keyword
void DortIslem(double a, double b, out double toplam, out double fark, out double carpim, out double bolum)

9. Recursion
int Faktoriyel(int sayi)
int BirdenSayiyaToplam(int sayi)
string Tersi(string metin)