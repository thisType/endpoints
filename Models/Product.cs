namespace AssessmentRest.Models
{
    public class Product
    {

        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; }

        public int ProductPrice { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
