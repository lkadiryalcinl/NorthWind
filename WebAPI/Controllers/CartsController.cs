using Business.Abstract;
using Core.Utilities.Session.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [Authorize]
    public class CartsController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly ICartSessionHelper _cartSessionHelper;
        private readonly IProductService _productService;

        public CartsController(ICartService cartService, ICartSessionHelper cartSessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = cartSessionHelper;
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var cart = _cartSessionHelper.GetCart("cart");
            var data = _cartService.CartList(cart);
            return Ok(data);
        }


        [HttpPost("addToCart")]
        public IActionResult Add(int productId)
        {
            var product = _productService.GetByID(productId);
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AddToCart(cart, product.Data);
            _cartSessionHelper.SetCart("cart", cart);

            return Ok(cart);
        }

        [HttpDelete("removeFromCart")]
        public IActionResult Delete(int productId)
        {
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.RemoveFromCart(cart, productId);
            _cartSessionHelper.SetCart("cart", cart);

            return Ok(cart);
        }

    }
}
