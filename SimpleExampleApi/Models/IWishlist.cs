namespace SimpleExampleApi.Models
{
    public interface IWishlist
    {
        string Name { get; set; }
        DateTime Created { get; set; }
        IList<IWishlistItem> Items { get; set; }
    }

    public class Wishlist : IWishlist
    {
        //Contructor
        public Wishlist(string name)
        {
            Name = name;
            Created = DateTime.Now;
            Items = new List<IWishlistItem>();
        }

        public string Name { get; set; }
        public DateTime Created { get; set; }
        public IList<IWishlistItem> Items { get; set; }
    }
}
