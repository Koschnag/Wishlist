namespace SimpleExampleApi.Models
{
    public interface IWishlistItem
    {
        string Name { get; set; }
        string Description { get; set; }
        DateTime Created { get; set; }
    }

    public class WishlistItem : IWishlistItem
    {
        //Contructor
        public WishlistItem(string name, string description)
        {
            Name = name;
            Description = description;
            Created = DateTime.Now;
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    }
}