namespace WishListWebApi.Models
{
    public interface IWishlistDto
    {
        string Name { get; set; }
        DateTime Created { get; set; }
        IList<IWishlistItemDto> Items { get; set; }
    }

    public class WishlistDto : IWishlistDto
    {

        public WishlistDto()
        {
            Created = DateTime.Now;
            Items = new List<IWishlistItemDto>();
        }
        //Contructor
        public WishlistDto(string name)
        {
            Name = name;
            Created = DateTime.Now;
            Items = new List<IWishlistItemDto>();
        }

        public string Name { get; set; }
        public DateTime Created { get; set; }
        public IList<IWishlistItemDto> Items { get; set; }
    }
}
