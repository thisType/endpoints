namespace AssessmentRest.Dto
{
    public class ProductDto
    {
        public Guid ProductId { get; set; }

        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; }
    }
}
