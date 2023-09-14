using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class RegionManager : IRegionService
    {
        private readonly IRegionDal _regionDal;

        public RegionManager(IRegionDal regionDal)
        {
            _regionDal = regionDal;
        }

        public IResult Add(Region region)
        {
            _regionDal.Add(region);
            return new SuccessResult(Messages.REGION_ADDED);
        }

        public IResult Delete(Region region)
        {
            _regionDal.Delete(region);
            return new SuccessResult(Messages.REGION_DELETED);
        }

        public IDataResult<List<Region>> GetAll()
        {
            var list = _regionDal.GetList();
            return new SuccessDataResult<List<Region>>(list);
        }

        public IDataResult<Region> GetByID(int regionId)
        {
            var order = _regionDal.Get(filter: r => r.RegionId == regionId);
            return new SuccessDataResult<Region>(order);
        }

        public IResult Update(Region region)
        {
            _regionDal.Update(region);
            return new SuccessResult(Messages.REGION_UPDATED);
        }
    }
}
