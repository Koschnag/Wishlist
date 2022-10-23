using WishListWebApi.DbContexts;
using WishListWebApi.Entities;

namespace WishListWebApi.Services
{
    public class Repository : IRepository
    {

        private readonly WishlistContexts _context;

        public Repository(WishlistContexts context)
        {
            _context = context;
        }

        public IList<Wishlist> GetAll()
        {
            return _context.Wishlists.ToList();
        }

        public void Add(Wishlist wishlist)
        {
            _context.Wishlists.Add(wishlist);
            _context.SaveChanges();
        }

        public void Update(int id, Wishlist wishlist)
        {
            var wishlistToUpdate = _context.Wishlists.FirstOrDefault(w => w.Id == id);
            if (wishlistToUpdate != null)
            {
                wishlistToUpdate.Name = wishlist.Name;
                _context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var wishlistToDelete = _context.Wishlists.FirstOrDefault(w => w.Id == id);
            if (wishlistToDelete != null)
            {
                _context.Wishlists.Remove(wishlistToDelete);
                _context.SaveChanges();
            }
        }
    }
}
