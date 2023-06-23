using Grpc.Core;
using Inventory;
using static Inventory.OrderService;

namespace Inventory.Services
{
    public class OrderService : OrderServiceBase
    {
        private readonly ILogger<OrderService> logger;
        public OrderService(ILogger<OrderService> _logger)
        {
            logger = _logger;
        }

        public override Task<OrderResponse> MakeOrder(Order request, ServerCallContext context)
        {
            logger.LogInformation($"Order Id: {request.OrderId}, Customer name:" +
                $" {request.Customer.CustomerName}");

            // Do business logic to check if item is available in inventory here
            var inStock = true;

            return Task.FromResult(new OrderResponse()
            {
                ResponseMessage = inStock
            });
        }
    }
}