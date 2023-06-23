using API.Models;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static Inventory.OrderService;
using static Payment.PaymentService;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product()
            {
                ProductId = 1,
                ProductDescription = $"This is product number 1",
                ProductName = "Product 1",
                ProductPrice = 5000
            },
            new Product()
            {
                ProductId = 2,
                ProductDescription = $"This is product number 2",
                ProductName = "Product 2",
                ProductPrice = 7000
            },
            new Product()
            {
                ProductId = 3,
                ProductDescription = $"This is product number 3",
                ProductName = "Product 3",
                ProductPrice = 9000
            },
        };
        [HttpPost]
        public async Task<IActionResult> MakeOrder([FromBody] Order order)
        {
            var customer = new Inventory.Customer()
            {
                CustomerId = order.Customer.CustomerId,
                CustomerName = order.Customer.CustomerName
            };

            var products = new List<Inventory.Product>();

            var totalPrice = 0;

            foreach(var product in order.Products)
            {
                totalPrice += product.ProductPrice;
                products.Add(new Inventory.Product()
                {
                    ProductId = product.ProductId,
                    ProductDescription = product.ProductDescription,
                    ProductName = product.ProductName,
                    ProductPrice = product.ProductPrice
                });
            }

            var requestedOrder = new Inventory.Order()
            {
                OrderId = order.Id,
                Customer = customer,
                TotalPrice = totalPrice
                //Products = products
            };
            var inventoryChannel = GrpcChannel.ForAddress("https://localhost:7052");
            var inventoryClient = new OrderServiceClient(inventoryChannel);

            var orderResponse = await inventoryClient.MakeOrderAsync(requestedOrder);

            if (orderResponse.ResponseMessage)
            {
                var paymentChannel = GrpcChannel.ForAddress("https://localhost:7168");
                var paymentClient = new PaymentServiceClient(paymentChannel);

                var paymentResponse = await paymentClient.MakePaymentAsync(new()
                {
                    CustomerId = customer.CustomerId,
                    ProductId = products[0].ProductId,
                    TotalPrice = totalPrice
                });
                if (paymentResponse.PaymentResponseMessage)
                    return Ok("Payment made successfully.");
                else
                    return BadRequest("An error occurred");
            }
            else
                return BadRequest("An error occurred");       
        }
    }
}
