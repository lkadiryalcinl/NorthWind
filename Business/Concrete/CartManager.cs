using Business.Abstract;
using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public CartLine AddToCart(Cart cart, Product product)
        {
            CartLine? cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId);
            if (cartLine == null)
            {
                cart.CartLines.Add(new CartLine { Product = product, Quantity = 1 });
                return cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId); ;
            }
            else
            {
                cartLine.Quantity += 1;
                return cart.CartLines.FirstOrDefault(c => c.Product.ProductId == product.ProductId); ;
            }
        }

        public string AdjustQuantity(Cart cart, int productId, byte adjustType)
        {
            CartLine? cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId);
            if (adjustType == 1 && cartLine.Product.UnitsInStock > cartLine.Quantity)
                cartLine.Quantity += 1;
            else if (adjustType == 0 && cartLine.Quantity != 1)
                cartLine.Quantity -= 1;
            else if (adjustType == 0 && cartLine.Quantity == 1)
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

        public CartLine RemoveFromCart(Cart cart, int productId)
        {
            CartLine? cartLine = cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId);
            cart.CartLines.Remove(cartLine);
            return cartLine;
        }
    }
}
