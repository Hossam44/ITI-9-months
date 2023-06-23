using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Task_buy_Product.Models;

namespace Task_buy_Product.Hubs
{
    public class QuantityHub : Hub
    {
        private readonly MyContext dbContext;

        public QuantityHub(MyContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void paymentMethod(int productId)
        {
            var product = dbContext.Products.Where(P=>P.Id== productId).FirstOrDefault();
            if(product?.Quantity > 0)
            {
                product.Quantity--;

                Clients.All.SendAsync("UpdateProduct", productId, product.Quantity);
                dbContext.SaveChanges();
            }
    
        }
        public void CommentMethod(int productId, string name, string text)
        {
            var newComment = new Comment() { Name= name, Text = text ,ProductId= productId };
            dbContext.Comments.Add(newComment);
            dbContext.SaveChanges();
            Clients.All.SendAsync("UpdateComments", productId, text);
        }


        
    }
}
