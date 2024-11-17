using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shopping_cart_MVCUI.Models
{
    [Table("CartDetail")]
    public class CartDetail
    {
        public int Id { get; set; }
        [Required]
        public int ShoppingCartId { get; set; }
        public int MenuId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Menu Menu { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
    }
}
