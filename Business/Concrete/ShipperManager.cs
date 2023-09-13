using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ShipperManager : IShipperService
    {
        private readonly IShipperDal _shipperDal;

        public ShipperManager(IShipperDal shipperDal)
        {
            _shipperDal = shipperDal;
        }

        public IResult Add(Shipper shipper)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Shipper shipper)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Shipper>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Shipper> GetByID(int shipperId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Shipper shipper)
        {
            throw new NotImplementedException();
        }
    }
}
