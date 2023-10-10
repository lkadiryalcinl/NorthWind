using Autofac;
using Business.Abstract;
using Business.Concrete;
using Business.Session.Concrete;
using Core.Utilities.Security.Helpers;
using Core.Utilities.Security.JWT;
using Core.Utilities.Session.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CartManager>().As<ICartService>().SingleInstance();
            builder.RegisterType<CartSessionHelper>().As<ICartSessionHelper>().SingleInstance();

            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();

            builder.RegisterType<RegionManager>().As<IRegionService>();
            builder.RegisterType<EfRegionDal>().As<IRegionDal>();

            builder.RegisterType<ShipperManager>().As<IShipperService>();
            builder.RegisterType<EfShipeerDal>().As<IShipperDal>();

            builder.RegisterType<SupplierManager>().As<ISupplierService>();
            builder.RegisterType<EfSupplierDal>().As<ISupplierDal>();

            builder.RegisterType<TerritoryManager>().As<ITerritoryService>();
            builder.RegisterType<EfTerritoryDal>().As<ITerritoryDal>();

            builder.RegisterType<UserManager>().As<IUserService>().SingleInstance();
            builder.RegisterType<EfUserDal>().As<IUserDal>().SingleInstance();

            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JWTHelper>().As<ITokenHelper>().SingleInstance();

            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();
        }
    }
}