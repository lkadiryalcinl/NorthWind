using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITerritoryService
    {
        IDataResult<List<Territory>> GetAll();
        IDataResult<List<Territory>> GetAll(int regionId);
        IDataResult<Territory> GetByID(int territoryId);
        IResult Add(Territory territory);
        IResult Update(Territory territory);
        IResult Delete(Territory territory);
    }
}
