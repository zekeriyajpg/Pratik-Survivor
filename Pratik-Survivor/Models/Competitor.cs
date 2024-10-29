namespace Pratik_Survivor.Models
{
    public class Competitor : BaseEntity
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public string FunFact { get; set; }

        // Foreign key
        public int CategoryId { get; set; }

        // Navigation property
        public Category Category { get; set; }
    }
}
