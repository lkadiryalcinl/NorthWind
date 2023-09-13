using Business.Abstract;
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
            throw new NotImplementedException();
        }

        public IResult Delete(Territory territory)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Territory>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Territory>> GetAll(int regionId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Territory> GetByID(int territoryId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Territory territory)
        {
            throw new NotImplementedException();
        }
    }
}
