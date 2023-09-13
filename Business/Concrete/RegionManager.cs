using Business.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(Region region)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Region>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Region> GetByID(int regionId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Region region)
        {
            throw new NotImplementedException();
        }
    }
}
