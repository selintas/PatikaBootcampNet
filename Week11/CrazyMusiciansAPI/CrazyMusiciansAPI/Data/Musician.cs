namespace CrazyMusiciansAPI.Data
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string profession { get; set; } = "";
        public string funFact { get; set; } = "";
        public int? YearsActive { get; set; }
    }
}
