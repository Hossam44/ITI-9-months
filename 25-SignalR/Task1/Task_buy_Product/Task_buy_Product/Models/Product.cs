using System.Xml.Linq;

namespace Task_buy_Product.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
