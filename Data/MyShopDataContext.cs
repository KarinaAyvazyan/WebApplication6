using Microsoft.EntityFrameworkCore;
using WebApplication6.Data.Entities;

namespace WebApplication6.Data
{
    public class MyShopDataContext:DbContext
    {
        public MyShopDataContext(DbContextOptions<MyShopDataContext> opt) : base(opt)
        { 



        }
       
        
        public DbSet<Product> Products { get; set; }    
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
 
        public DbSet<Vendor> Vendors { get; set; }

   

    }
}
