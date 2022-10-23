namespace WishListWebApi.Models
{
    public interface IWishlistItemDto
    {
        string Name { get; set; }
        string Description { get; set; }
        DateTime Created { get; set; }
    }

    public class WishlistItemDto : IWishlistItemDto
    {
        //Contructor
        public WishlistItemDto(string name, string description)
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