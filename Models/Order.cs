using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "UserId is required!")]
        public int UserId { get; set; }

        [Required(ErrorMessage = "ProdusName is required!")]
        public string ProdusName { get; set; }
    }
}
