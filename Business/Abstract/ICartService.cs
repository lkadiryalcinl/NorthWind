using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Abstract
{
    public interface ICartService
    {
        CartLine AddToCart(Cart cart,Product product);
        CartLine RemoveFromCart(Cart cart,int productId);
        string AdjustQuantity(Cart cart,int productId,byte adjustType);
        List<CartLine> CartList(Cart cart);
    }
}
