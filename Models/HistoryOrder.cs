using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class HistoryOrder
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "NumberOrder is required!")]
        public string NumberOrder { get; set; }

        [Required(ErrorMessage = "ProdusName is required!")]
        public string ProdusName { get; set; }

        [Required(ErrorMessage = "Quantity is required!")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Total is required!")]
        public double Total { get; set; }

        [Required(ErrorMessage = "UserId is required!")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
    }
}
