namespace AssessmentRest.Models
{
    public class User
    {

        public Guid UserId { get; set; }

        public string UserName { get; set; } = string.Empty;

        public virtual ICollection<Order> Orders { get; set; }
    }
}
