﻿using API.Protos;
using Grpc.Core;
using Grpc.Net.Client;
using static API.Protos.APIOrderService;
using static Inventory.OrderService;
using static Payment.PaymentService;

namespace API.Services
{
    public class APIOrderService : APIOrderServiceBase
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
        public override async Task<OrderResponse> MakeOrder(Order order, ServerCallContext context)
        {
            var customer = new Inventory.Customer()
            {
                CustomerId = order.Customer.CustomerId,
                CustomerName = order.Customer.CustomerName
            };

            var products = new List<Inventory.Product>();

            var totalPrice = 0;

            foreach (var product in order.Products)
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
                OrderId = order.OrderId,
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
                    return new OrderResponse()
                    {
                        ResponseMessage = true
                    };
                else
                    return new OrderResponse()
                    {
                        ResponseMessage = false
                    };
            }
            else
                    return new OrderResponse()
                    {
                        ResponseMessage = false
                    };
        }
    }
}
