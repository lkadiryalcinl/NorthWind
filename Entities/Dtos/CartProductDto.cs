using Core.Entities.Abstract;

namespace Entities.Dtos
{
    public class CartProductDto : IDto
    {
        public int ProductId { get; set; }
        public byte AdjustType { get; set; }

    }
}
