using PratikPatikaKütüphane;

public class Program
{
    public static void Main(string[] args)
    {
        // Tabloya göre kitap nesnelerini oluşturma
        Kitap kitap1 = new Kitap("Bir Kitap", "Ahmet", "Yılmaz", 320, "Alfa Yayınları");
        Kitap kitap2 = new Kitap("Başka Bir Kitap", "Ayşe", "Karan", 215, "Beta Yayıncılık");
        Kitap kitap3 = new Kitap("Daha Başka Kitap", "Mehmet", "Demir", 450, "Gamma Yayınları");
        Kitap kitap4 = new Kitap("Son Kitap", "Elif", "Şahin", 275, "Delta Yayıncılık");
        Kitap kitap5 = new Kitap("Örnek Kitap", "Selin", "Yurt", 198, "Epsilon Yayınları");

        // Kitap bilgilerini yazdırma
        kitap1.KitapBilgiYazdır();
        kitap2.KitapBilgiYazdır();
        kitap3.KitapBilgiYazdır();
        kitap4.KitapBilgiYazdır();
        kitap5.KitapBilgiYazdır();
}
}