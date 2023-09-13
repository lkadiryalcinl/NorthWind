using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.Helpers;
using MvcWebUI.Models;

namespace MvcWebUI.Controllers
{
    public class CartController : Controller
    {
        private ICartService _cartService;
        private ICartSessionHelper _cartSessionHelper;
        private IProductService _productService;

        public CartController(ICartService cartService, ICartSessionHelper sessionHelper, IProductService productService)
        {
            _cartService = cartService;
            _cartSessionHelper = sessionHelper;
            _productService = productService;
        }


        public IActionResult AddToCart(int productId)
        {
            Product product = _productService.GetByID(productId).Data;
            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.AddToCart(cart, product);
            _cartSessionHelper.SetCart("cart", cart);
            TempData.Add("message", product.ProductName + " succesfully added to cart.");
            return RedirectToAction("Index", "Product");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            Product product = _productService.GetByID(productId).Data;
            var cart = _cartSessionHelper.GetCart("cart");

            _cartService.RemoveFromCart(cart, productId);
            _cartSessionHelper.SetCart("cart", cart);
            TempData.Add("message", product.ProductName + " succesfully removed from cart.");
            return RedirectToAction("Index", "Cart");
        }

        public IActionResult AdjustQuantity(int productId, string adjustType)
        {
            Product product = _productService.GetByID(productId).Data;
            var cart = _cartSessionHelper.GetCart("cart");

            string res = _cartService.AdjustQuantity(cart, productId, adjustType);
            _cartSessionHelper.SetCart("cart", cart);

            if (res == "removed")
                TempData.Add("message", product.ProductName + " succesfully removed from cart.");

            return RedirectToAction("Index", "Cart");
        }

        public IActionResult Complete()
        {
            var model = new ShippingDetailsViewModel
            {
                ShippingDetail = new ShippingDetail()
            };

            return View(model);
        }

        public IActionResult Index()
        {
            var model = new CartListViewModel
            {
                Cart = _cartSessionHelper.GetCart("cart")
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Complete(ShippingDetail shippingDetail)
        {
            TempData.Add("message", "We took your order succesfully.");
            _cartSessionHelper.Clear();
            return RedirectToAction("Index", "Cart");
        }
    }
}
