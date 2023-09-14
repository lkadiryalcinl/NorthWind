using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SupplierManager : ISupplierService
    {
        private readonly ISupplierDal _supplierDal;

        public SupplierManager(ISupplierDal supplierDal)
        {
            _supplierDal = supplierDal;
        }

        public IResult Add(Supplier supplier)
        {
            _supplierDal.Add(supplier);
            return new SuccessResult(Messages.SUPPLIER_ADDED);
        }

        public IResult Delete(Supplier supplier)
        {
            _supplierDal.Delete(supplier);
            return new SuccessResult(Messages.SUPPLIER_DELETED);
        }

        public IDataResult<List<Supplier>> GetAll()
        {
            var list = _supplierDal.GetList();
            return new SuccessDataResult<List<Supplier>>(list);
        }

        public IDataResult<Supplier> GetByID(int supplierId)
        {
            var supplier = _supplierDal.Get(filter: s => s.SupplierId == supplierId);
            return new SuccessDataResult<Supplier>(supplier);
        }

        public IResult Update(Supplier supplier)
        {
            _supplierDal.Update(supplier);
            return new SuccessResult(Messages.SUPPLIER_UPDATED);
        }
    }
}