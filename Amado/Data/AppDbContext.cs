using Amado.Models;
using Microsoft.EntityFrameworkCore;

namespace Amado.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart_ItemModel>().HasKey(ci => new { ci.CartID, ci.ItemID });

            modelBuilder.Entity<Cart_ItemModel>().HasOne(c => c.Cart).WithMany(ci => ci.CartItems).HasForeignKey(c => c.CartID);
            modelBuilder.Entity<Cart_ItemModel>().HasOne(i => i.Item).WithMany(ci => ci.CartItems).HasForeignKey(i => i.ItemID);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<UserModel> User { get; set; }
        public DbSet<ItemModel> Item { get; set; }
        public DbSet<ImageModel> Image { get; set; }
        public DbSet<CartModel> Cart { get; set; }
        public DbSet<Cart_ItemModel> Cart_Item { get; set; }
        public DbSet<OrderModel> Order { get; set; }
    }
}
