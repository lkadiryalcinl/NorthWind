using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Contexts;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CartManager>().As<ICartService>().SingleInstance();

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
        }
    }
}