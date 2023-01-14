using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Username is required!")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        public string Password { get; set; }

        [NotMapped]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Role is required!")]
        public int RoleId { get; set; }
        
        public bool IsOnline { get; set; }

        public bool IsDeleted { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

    }
}
