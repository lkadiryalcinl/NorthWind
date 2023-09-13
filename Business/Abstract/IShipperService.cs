using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IShipperService
    {
        IDataResult<List<Shipper>> GetAll();
        IDataResult<Shipper> GetByID(int shipperId);
        IResult Add(Shipper shipper);
        IResult Update(Shipper shipper);
        IResult Delete(Shipper shipper);
    }
}
