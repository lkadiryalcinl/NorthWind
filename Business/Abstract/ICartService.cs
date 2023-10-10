using Entities.Concrete;
using Entities.DomainModels;

namespace Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart,Product product);
        void RemoveFromCart(Cart cart,int productId);
        string AdjustQuantity(Cart cart,int productId,string adjustType);
        List<CartLine> CartList(Cart cart);
    }
}
