using PratikAbstraction;
class Program
{
    static void Main(string[] args)
    {
        // Proje yöneticisi nesnesi
        Calisan projeYoneticisi = new ProjeYoneticisi
        {
            Ad = "Hasan",
            Soyad = "Çıldırmış",
            Departman = "Proje Yönetimi"
        };

        // Yazılım geliştirici nesnesi
        Calisan yazilimGelistirici = new YazilimGelistirici
        {
            Ad = "Ayşe",
            Soyad = "Deli",
            Departman = "Yazılım Geliştirme"
        };

        // Satış temsilcisi nesnesi
        Calisan satisTemsilcisi = new SatisTemsilcisi
        {
            Ad = "Mehmet",
            Soyad = "Kayalar",
            Departman = "Satış"
        };

        // Çalışanların görevlerini çağırma
        projeYoneticisi.Gorev();        // Çıktı: Proje yöneticisi olarak çalışıyorum.
        yazilimGelistirici.Gorev();     // Çıktı: Yazılım geliştirici olarak çalışıyorum.
        satisTemsilcisi.Gorev();        // Çıktı: Satış temsilcisi olarak çalışıyorum.
    }
}
