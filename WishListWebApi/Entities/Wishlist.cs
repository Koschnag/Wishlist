
using System.ComponentModel.DataAnnotations;

namespace WishListWebApi.Entities
{
    public class Wishlist
    {
        private static int _id = 0;
        //Contructor
        public Wishlist(string name)
        {
            Id = _id++;
            Name = name;
            Created = DateTime.Now;
            Items = new List<WishlistItem>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime Created { get; set; }
        public IList<WishlistItem> Items { get; set; }
    }
}
