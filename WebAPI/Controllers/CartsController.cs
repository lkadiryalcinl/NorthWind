using Business.Abstract;
using Core.Utilities.Session.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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
        public IActionResult Add(Product product)
        {
            var selectedProduct = _productService.GetByID(product.ProductId);
            var cart = _cartSessionHelper.GetCart("cart");
            var addedItem = _cartService.AddToCart(cart, selectedProduct.Data);
            _cartSessionHelper.SetCart("cart", cart);

            return Ok(addedItem);
        }

        [HttpDelete("removeFromCart")]
        public IActionResult Delete(CartProductDto cartProductDto)
        {
            var cart = _cartSessionHelper.GetCart("cart");
            var removedItem = _cartService.RemoveFromCart(cart, cartProductDto.ProductId);
            _cartSessionHelper.SetCart("cart", cart);

            return Ok(removedItem);
        }

        [HttpPut("adjustQuantity")]
        public IActionResult Put(CartProductDto cartProductDto)
        {
            var cart = _cartSessionHelper.GetCart("cart");
            _cartService.AdjustQuantity(cart, cartProductDto.ProductId, cartProductDto.AdjustType);
            _cartSessionHelper.SetCart("cart", cart);
            return Ok();
        }
    }
}
