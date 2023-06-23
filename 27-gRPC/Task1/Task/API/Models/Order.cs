using System.Text.Json.Serialization;

namespace API.Models
{
    public class Order
    {
        public int Id { get; set; }
		public List<Product> Products { get; set; }

		[JsonIgnore]
		public int TotalPrice { get; set; }
		public Customer Customer { get; set; }
	}
}
