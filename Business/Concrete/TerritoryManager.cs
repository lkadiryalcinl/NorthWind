using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TerritoryManager : ITerritoryService
    {
        private readonly ITerritoryDal _territoryDal;

        public TerritoryManager(ITerritoryDal territoryDal)
        {
            _territoryDal = territoryDal;
        }

        public IResult Add(Territory territory)
        {
            _territoryDal.Add(territory);
            return new SuccessResult(Messages.TERRITORY_ADDED);
        }

        public IResult Delete(Territory territory)
        {
            _territoryDal.Delete(territory);
            return new SuccessResult(Messages.TERRITORY_DELETED);
        }

        public IDataResult<List<Territory>> GetAll()
        {
            var list = _territoryDal.GetList();
            return new SuccessDataResult<List<Territory>>(list);
        }

        public IDataResult<List<Territory>> GetAll(int regionId)
        {
            var list = _territoryDal.GetList(filter: t => t.RegionId == regionId);
            return new SuccessDataResult<List<Territory>>(list);
        }

        public IDataResult<Territory> GetByID(int territoryId)
        {
            var territory = _territoryDal.Get(filter: t => t.TerritoryId == territoryId);
            return new SuccessDataResult<Territory>(territory);
        }

        public IResult Update(Territory territory)
        {
            _territoryDal.Update(territory);
            return new SuccessResult(Messages.TERRITORY_UPDATED);
        }
    }
}
