using Grpc.Core;
using static Payment.PaymentService;

namespace Payment.Services
{
    public class PaymentService : PaymentServiceBase
    {
        private readonly ILogger<PaymentService> logger;
        public static List<int> CustomerIds = new List<int> { 1, 2, 3 };
        public static List<int> ProductIds = new List<int> { 1, 2, 3 };

        public PaymentService(ILogger<PaymentService> logger)
        {
            this.logger = logger;
        }
        public override Task<PaymentResponse> MakePayment(PaymentRequest request, ServerCallContext context)
        {
            if (CustomerIds.Contains(request.CustomerId)
                && ProductIds.Contains(request.ProductId))
                return Task.FromResult(new PaymentResponse()
                {
                    PaymentResponseMessage = true
                });
            else
                return Task.FromResult(new PaymentResponse()
                {
                    PaymentResponseMessage = false
                });
        }

    }
}