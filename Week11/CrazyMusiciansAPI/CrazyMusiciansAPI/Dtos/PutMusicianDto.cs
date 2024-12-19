namespace CrazyMusiciansAPI.Dtos
{
    public class PutMusicianDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Instrument { get; set; } = "";
        public string Genre { get; set; } = "";
        public int YearsActive { get; set; }

    }//guncelle ıd de al
}
