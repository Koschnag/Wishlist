using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WishListWebApi.Entities
{
    public class WishlistItem
    {
        private static int _id = 0;
        //Contructor
        public WishlistItem(string name, string description)
        {
            Id = _id++;
            Name = name;
            Description = description;
            Created = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey("Wishlist")]
        public int WishlistId { get; set; }
    }
}