namespace CrazyMusiciansAPI.Data
{
    public static class DataStore
    {
        private static List<Musician> _musicians = new()
        {
            new Musician { Id = 1, Name = "Ahmet Çalgı", Instrument = "Ünlü Çalgı Çalar", Genre = "Her zaman yanlış nota çalar, ama çok eğlenceli", YearsActive = 5 },
            new Musician { Id = 2, Name = "Zeynep Melodi", Instrument = "Popüler Melodi Yazarı", Genre = "Şarkıları yanlış anlaşılır ama çok popüler", YearsActive = 7 },
            new Musician { Id = 3, Name = "Cemil Akor", Instrument = "Çılgın Akorist", Genre = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli", YearsActive = 10 },
            new Musician { Id = 4, Name = "Fatma Nota", Instrument = "Sürpriz Nota Üreticisi", Genre = "Nota üretirken sürekli sürprizler hazırlar", YearsActive = 8 },
            new Musician { Id = 5, Name = "Hasan Ritim", Instrument = "Ritim Canavarı", Genre = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir", YearsActive = 6 },
            new Musician { Id = 6, Name = "Elif Armoni", Instrument = "Armoni Ustası", Genre = "Armonilerini bazen yanlış çalar, ama çok yaratıcıdır", YearsActive = 15 },
            new Musician { Id = 7, Name = "Ali Perde", Instrument = "Perde Uygulayıcı", Genre = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir", YearsActive = 12 },
            new Musician { Id = 8, Name = "Ayşe Rezonans", Instrument = "Rezonans Uzmanı", Genre = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır", YearsActive = 9 },
            new Musician { Id = 9, Name = "Murat Ton", Instrument = "Tonlama Meraklısı", Genre = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç", YearsActive = 11 },
            new Musician { Id = 10, Name = "Selin Akor", Instrument = "Akor Sihirbazı", Genre = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır", YearsActive = 14 }
        };
        public static List<Musician> Musicians()
        {
            return _musicians;
        }

    }
}
