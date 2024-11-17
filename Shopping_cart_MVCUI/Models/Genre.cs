using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_cart_MVCUI.Models
{
    [Table("Genre")]
    public class Genre
    {
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }
        public List<Menu> Menus { get; set; }
    }
}
