using Business.Abstract;
using Business.Constants;
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
            _shipperDal.Add(shipper);
            return new SuccessResult(Messages.SHIPPER_ADDED);
        }

        public IResult Delete(Shipper shipper)
        {
            _shipperDal.Delete(shipper);
            return new SuccessResult(Messages.SHIPPER_DELETED);
        }

        public IDataResult<List<Shipper>> GetAll()
        {
            var list = _shipperDal.GetList();
            return new SuccessDataResult<List<Shipper>>(list);
        }

        public IDataResult<Shipper> GetByID(int shipperId)
        {
            var Shipper = _shipperDal.Get(filter: s => s.ShipperId == shipperId);
            return new SuccessDataResult<Shipper>(Shipper);
        }

        public IResult Update(Shipper shipper)
        {
            _shipperDal.Update(shipper);
            return new SuccessResult(Messages.SHIPPER_UPDATED);
        }
    }
}
