using WishListWebApi.Entities;

namespace WishListWebApi.Services
{
    public interface IRepository
    {
        public IList<Wishlist> GetAll();
        public void Add(Wishlist wishlist);
        public void Update(int id, Wishlist wishlist);
        public void Delete(int id);
    }
}
