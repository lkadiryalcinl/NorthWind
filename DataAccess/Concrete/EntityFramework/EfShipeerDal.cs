using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfShipeerDal : EfEntityRepositoryBase<Shipper,NorthwindContext>,IShipperDal
    {
    }
}
