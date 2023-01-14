using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Role
    {
        public Role()
        { }

        public Role(string name)
        {
            Name = name;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}
