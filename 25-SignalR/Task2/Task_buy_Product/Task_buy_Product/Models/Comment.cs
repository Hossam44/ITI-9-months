using System.ComponentModel.DataAnnotations.Schema;

namespace Task_buy_Product.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Name { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
