using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product)
        {
            CartLine? cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartLine == null)
            {
                cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
                return;
            }
            else
            {
                cartLine.Quantity += 1;
                return;
            }
        }

        public string AdjustQuantity(Cart cart, int productId, string adjustType)
        {
            CartLine? cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId);
            if (adjustType == "increase" && cartLine.Product.UnitsInStock > cartLine.Quantity)
                cartLine.Quantity += 1;
            else if (adjustType == "decrease" && cartLine.Quantity != 1)
                cartLine.Quantity -= 1;
            else if (adjustType == "decrease" && cartLine.Quantity == 1)
            {
                cart.CartLines.Remove(cartLine);
                return "removed";
            }
            return "";
        }

        public List<CartLine> CartList(Cart cart)
        {
            return cart.CartLines;
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            CartLine? cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId);
            cart.CartLines.Remove(cartLine);
            return;
        }
    }
}
