using Microsoft.AspNetCore.Mvc;
using WishListWebApi.Entities;
using WishListWebApi.Models;
using WishListWebApi.Services;

namespace WishListWebApi.Controllers
{
    [ApiController]
    [Route("api/wishlist")]
    public class WishlistController:ControllerBase
    {
        private readonly IRepository repository;

        //Contructor Injection
        public WishlistController(IRepository repository)
        {
            this.repository = repository;
        }

        //Return all Wishlist as Json 
        [HttpGet]
        [Route("all")]
        public JsonResult GetAllWishlist()
        {
            return new JsonResult(repository.GetAll());
        }

        //Add a new Wishlist to the wishlistManager
        [HttpGet]
        [Route("add")]
        public JsonResult AddWishlist()
        {
            var wishlist = new Wishlist("new Wishlist");
            repository.Add(wishlist);
            return new JsonResult(repository.GetAll());
        }
    }
}
