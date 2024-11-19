using PratikPatikafyMüzikPlatform;

public class Program
{
    public static void Main(string[] args)
    {
        // Sanatçıların listesi
        List<Singer> singers = new List<Singer>
        {
            new Singer { Name = "Ajda Pekkan", MusicGenre = "Pop", DebutYear = 1968, AlbumSales = 20 },
            new Singer { Name = "Sezen Aksu", MusicGenre = "Türk Halk Müziği / Pop", DebutYear = 1971, AlbumSales = 10 },
            new Singer { Name = "Funda Arar", MusicGenre = "Pop", DebutYear = 1999, AlbumSales = 3 },
            new Singer { Name = "Sertab Erener", MusicGenre = "Pop", DebutYear = 1994, AlbumSales = 5 },
            new Singer { Name = "Sıla", MusicGenre = "Pop", DebutYear = 2009, AlbumSales = 3 },
            new Singer { Name = "Serdar Ortaç", MusicGenre = "Pop", DebutYear = 1994, AlbumSales = 10 },
            new Singer { Name = "Tarkan", MusicGenre = "Pop", DebutYear = 1992, AlbumSales = 40 },
            new Singer { Name = "Hande Yener", MusicGenre = "Pop", DebutYear = 1999, AlbumSales = 7 },
            new Singer { Name = "Hadise", MusicGenre = "Pop", DebutYear = 2005, AlbumSales = 5 },
            new Singer { Name = "Gülben Ergen", MusicGenre = "Pop / Türk Halk Müziği", DebutYear = 1997, AlbumSales = 10 },
            new Singer { Name = "Neşet Ertaş", MusicGenre = "Türk Halk Müziği / Türk Sanat Müziği", DebutYear = 1960, AlbumSales = 2 }
        };
        // 1. Adı 'S' ile başlayan şarkıcılar
        //var NameS = singers.Where(s => s.Name.StartsWith("S")).ToList();

        var NameS = from singer in singers
                    where singer.Name.StartsWith("S")
                    select singer;

        foreach (var singer in NameS)
        {
            Console.WriteLine(singer.Name);
        }
        Console.WriteLine("\n_____");

        // 2. Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
        //var highSalesSingers = singers.Where(s => s.AlbumSales > 10).ToList();
        var highSalesSingers = from singer in singers
                               where singer.AlbumSales > 10
                               select singer;

        foreach (var singer in highSalesSingers)
        { Console.WriteLine(singer.Name); }
        Console.WriteLine("\n_____");

        // 3. 2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar
        var earlyPopSingers = singers.Where(s => s.DebutYear < 2000 && s.MusicGenre.Contains("Pop"))
                                     .OrderBy(s => s.DebutYear)
                                     .ThenBy(s => s.Name)
                                     .ToList(); 
        foreach(var singer in earlyPopSingers)
        { Console.WriteLine($"Şarkıcı Adı : {singer.Name} || Çıkış Yılı : {singer.DebutYear}"); }
        Console.WriteLine("\n_____");

        // 4. En çok albüm satan şarkıcı
        var topSeller = singers.OrderByDescending(s => s.AlbumSales).First();  // satış sayısına göre azalan sırayla

        Console.WriteLine($"\"En çok albüm satan şarkıcı: {topSeller}");
        Console.WriteLine("\n_____");

        // 5. En yeni ve en eski çıkış yapan şarkıcı
        var newestSinger = singers.OrderByDescending(s => s.DebutYear).FirstOrDefault(); //.First(); olabılır.

        var oldestSinger = singers.OrderBy(s => s.DebutYear).FirstOrDefault(); //.First(); olabılır.

        Console.WriteLine($"En yeni çıkış yapan şarkıcı:{newestSinger}  \nEn eski çıkış yapan şarkıcı:{oldestSinger} ");

       
       
    }
}
