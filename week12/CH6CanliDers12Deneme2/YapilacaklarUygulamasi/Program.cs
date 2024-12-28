using YapilacaklarUygulamasi.Data;

anamenu:
Console.WriteLine("*** YAPILACAKLAR ***");
using (var db = new UygulamaDbContext())
{
    foreach (Gorev gorev in db.Gorevler.OrderBy(g => g.Yapildi))
    {
        string durum = gorev.Yapildi ? "[x]" : "[ ]";
        Console.WriteLine($"{durum} {gorev.Id,2} {gorev.Baslik}");
    }
}

Console.WriteLine(@"
1. Yeni Görev Ekle
2. Mevcut Bir Görevi 'Yapıldı' Olarak İşaretle
3. Mevcut Bir Görevi 'Yapılmadı' Olarak İşaretle
4. Mevcut Bir Görevi Sil
");

Console.Write("Yapacağınız işlemin nosunu giriniz: ");
string tercih = Console.ReadLine();

if (tercih == "1")
{
    Console.Write("Yeni Görev: ");
    string baslik = Console.ReadLine();

    using (var db = new UygulamaDbContext())
    {
        Gorev gorev = new Gorev() { Baslik = baslik };
        db.Gorevler.Add(gorev);
        db.SaveChanges();

        MesajGoster("Yeni görev başarıyla eklendi.");
        goto anamenu;
    }
}
else if (tercih == "2")
{
    Console.Write("Yapıldı olarak işaretlenecek görevin nosu: ");
    int id = Convert.ToInt32(Console.ReadLine());

    using (var db = new UygulamaDbContext())
    {
        Gorev? gorev = db.Gorevler.Find(id);

        if (gorev == null)
        {
            MesajGoster("Belirttiğiniz no ile ilişkili bir görev bulunamadı.");
            goto anamenu;
        }

        gorev.Yapildi = true;
        db.SaveChanges();

        MesajGoster("Belirttiğiniz görev başarıyla güncellendi.");
        goto anamenu;
    }
}
else if (tercih == "3")
{
    Console.Write("Yapılmadı olarak işaretlenecek görevin nosu: ");
    int id = Convert.ToInt32(Console.ReadLine());

    using (var db = new UygulamaDbContext())
    {
        Gorev? gorev = db.Gorevler.Find(id);

        if (gorev == null)
        {
            MesajGoster("Belirttiğiniz no ile ilişkili bir görev bulunamadı.");
            goto anamenu;
        }

        gorev.Yapildi = false;
        db.SaveChanges();

        MesajGoster("Belirttiğiniz görev başarıyla güncellendi.");
        goto anamenu;
    }
}
else if (tercih == "4")
{
    Console.Write("Silinecek Görevin Nosu: ");
    int id = Convert.ToInt32(Console.ReadLine());

    using (var db = new UygulamaDbContext())
    {
        Gorev? gorev = db.Gorevler.Find(id);

        if (gorev == null)
        {
            MesajGoster("Belirttiğiniz no ile ilişkili bir görev bulunamadı.");
            goto anamenu;
        }

        db.Gorevler.Remove(gorev);
        db.SaveChanges();

        MesajGoster("Belirttiğiniz görev başarıyla silindi.");
        goto anamenu;
    }
}
else
{
    Console.WriteLine("Geçersiz seçim!");
}

Console.ReadKey();

void MesajGoster(string mesaj)
{
    Console.Clear();
    Console.WriteLine("### " + mesaj + " ###");
    Console.WriteLine();
}