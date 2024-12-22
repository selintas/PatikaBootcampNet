namespace CrazyMusiciansAPI.Data
{
    public static class DataStore
    {
        private static List<Musician> _musicians = new()
        {
            new Musician { Id = 1, Name = "Ahmet Çalgı", profession = "Ünlü Çalgı Çalar", funFact = "Her zaman yanlış nota çalar, ama çok eğlenceli", YearsActive = 5 },
            new Musician { Id = 2, Name = "Zeynep Melodi", profession = "Popüler Melodi Yazarı", funFact = "Şarkıları yanlış anlaşılır ama çok popüler", YearsActive = 7 },
            new Musician { Id = 3, Name = "Cemil Akor", profession = "Çılgın Akorist", funFact = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli", YearsActive = 10 },
            new Musician { Id = 4, Name = "Fatma Nota", profession = "Sürpriz Nota Üreticisi", funFact = "Nota üretirken sürekli sürprizler hazırlar", YearsActive = 8 },
            new Musician { Id = 5, Name = "Hasan Ritim", profession = "Ritim Canavarı", funFact = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir", YearsActive = 6 },
            new Musician { Id = 6, Name = "Elif Armoni", profession = "Armoni Ustası", funFact = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır", YearsActive = 15 },
            new Musician { Id = 7, Name = "Ali Perde", profession = "Perde Uygulayıcı", funFact = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir", YearsActive = 12 },
            new Musician { Id = 8, Name = "Ayşe Rezonans", profession = "Rezonans Uzmanı", funFact = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır", YearsActive = 9 },
            new Musician { Id = 9, Name = "Murat Ton", profession = "Tonlama Meraklısı", funFact = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç", YearsActive = 11 },
            new Musician { Id = 10, Name = "Selin Akor", profession = "Akor Sihirbazı", funFact = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır", YearsActive = 14 }
        };
        public static List<Musician> Musicians()
        {
            return _musicians;
        }

    }
}
