namespace Survivor.Models
{
    public class Category
    {
        public string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; }
    }
}
