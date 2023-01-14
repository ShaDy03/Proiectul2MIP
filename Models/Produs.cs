using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Produs
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "ProdusName is required!")]
        public string ProdusName { get; set; }

        [Required(ErrorMessage = "Quantity is required!")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        public double Price { get; set; }

        public string Description { get; set; }
    }
}
