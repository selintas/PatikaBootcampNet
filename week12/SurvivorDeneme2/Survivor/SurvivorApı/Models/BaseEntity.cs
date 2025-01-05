namespace SurvivorApı.Models
{
    public abstract class BaseEntity<T>
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }

        public bool IsDeleted { get; set; } // Yeni özellik
    }
}
