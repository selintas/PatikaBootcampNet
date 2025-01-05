namespace Survivor.Models
{
    public class Category : BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<Competitor> Competitors { get; set; }
    }
}
