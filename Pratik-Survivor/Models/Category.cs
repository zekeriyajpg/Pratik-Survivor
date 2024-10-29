namespace Pratik_Survivor.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        // Navigation property
        public ICollection<Competitor> Competitors { get; set; } = new List<Competitor>();
    }
}
