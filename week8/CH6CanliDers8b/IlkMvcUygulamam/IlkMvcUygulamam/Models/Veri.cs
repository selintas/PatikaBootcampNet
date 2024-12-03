namespace IlkMvcUygulamam.Models
{
    public class Veri
    {
        public static List<Hobi> Hobilerim()
        {
            return new List<Hobi>()
            {
                new Hobi() { Ad = "Bilgisayar Oyunları", Derece = 4 },
                new Hobi() { Ad = "Film İzlemek", Derece = 4 },
                new Hobi() { Ad = "Halay Çekmek", Derece = 3 },
                new Hobi() { Ad = "Dedikodu Yapmak", Derece = 5 },
                new Hobi() { Ad = "Enstrüman Çalmak", Derece = 5 },
                new Hobi() { Ad = "Boks", Derece = 3 },
                new Hobi() { Ad = "Kahve İçmek", Derece = 5 },
                new Hobi() { Ad = "Kayak", Derece = 3 },
                new Hobi() { Ad = "Arkadaşlarıma Reels Atmak", Derece = 5 }

            };
        }
    }
}
