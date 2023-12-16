using System.ComponentModel.DataAnnotations.Schema;

namespace AssessmentRest.Models
{
    public class Order
    {

        public Guid OrderId {  get; set; }

        public  int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product product { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User user { get; set; }


    }
}
