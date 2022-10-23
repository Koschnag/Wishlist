using Microsoft.EntityFrameworkCore;
using WishListWebApi.Entities;
using WishListWebApi.Models;

namespace WishListWebApi.DbContexts
{
    
    public class WishlistContexts:DbContext
    {
        public DbSet<Wishlist> Wishlists { get; set; } = null!;

        public WishlistContexts(DbContextOptions<WishlistContexts> options) : base(options)
        {
            
        }

    }
}
