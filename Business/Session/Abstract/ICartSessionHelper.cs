using Entities.DomainModels;

namespace Core.Utilities.Session.Abstract
{
    public interface ICartSessionHelper
    {
        public void Clear();
        public Cart GetCart(string key);
        public void SetCart(string key, Cart cart);
    }
}
