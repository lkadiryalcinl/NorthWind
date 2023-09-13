using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRegionService
    {
        IDataResult<List<Region>> GetAll();
        IDataResult<Region> GetByID(int regionId);
        IResult Add(Region region);
        IResult Update(Region region);
        IResult Delete(Region region);
    }
}
