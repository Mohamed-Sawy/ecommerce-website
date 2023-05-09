using Amado.Data.Enums;
using Amado.Models;
using static System.Net.Mime.MediaTypeNames;

namespace Amado.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Item.Any())
                {
                    context.Item.AddRange(new List<Item>()
                    {
                        new Item()
                        {
                            Name = "Modern Chair",
                            Price = 180,
                            Rate = 5,
                            Category = Category.Chairs,
                            Brand = Brand.Amado,
                            Color = Color.White,
                            Quantity = 50,
                        },
                    });

                    context.SaveChanges();
                }
                if (!context.Image.Any())
                {
                    context.Image.AddRange(new List<Models.Image>()
                    {
                        new Models.Image()
                        {
                            ItemID = 1,
                            ImageURL = "~/assets/8.jpg.webp",
                        },
                    });

                    context.SaveChanges();
                }
                if (!context.Cart.Any())
                {
                    context.Cart.AddRange(new List<Cart>()
                    {
                        new Cart()
                        {
                            TotalPrice = 180,
                        },
                    });

                    context.SaveChanges();
                }
                if (!context.Cart_Item.Any())
                {
                    context.Cart_Item.AddRange(new List<Cart_Item>()
                    {
                        new Cart_Item()
                        {
                            CartID = 1,
                            ItemID = 1,
                            Quantity = 1,
                        },
                    });

                    context.SaveChanges();
                }
                if (!context.User.Any())
                {
                    context.User.AddRange(new List<User>()
                    {
                        new User()
                        {
                            CartID = 1,
                            FirstName = "test",
                            SecondName = "user",
                            CompanyName = "Google",
                            Email = "test@google.com",
                            Country = Country.Egypt,
                            Address = "20 test street",
                            Town = "test town",
                            ZIPCode = "123",
                            PhoneNo = "0123",
                        },
                    });

                    context.SaveChanges();
                }
                if (!context.Order.Any())
                {
                    context.Order.AddRange(new List<Order>()
                    {
                        new Order()
                        {
                            UserID = 1,
                            Comment = "test comment",
                        },
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
