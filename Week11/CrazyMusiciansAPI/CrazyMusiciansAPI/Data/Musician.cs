namespace CrazyMusiciansAPI.Data
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Instrument { get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public int YearsActive { get; set; }
    }
}
