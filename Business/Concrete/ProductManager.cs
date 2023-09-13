using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<List<Product>> GetAll(int categoryId)
        {
            var list = _productDal.GetList(filter: p => p.CategoryId == categoryId);
            return new SuccessDataResult<List<Product>>(list);
        }

        public IDataResult<List<Product>> GetAll()
        {
            var list = _productDal.GetList();
            return new SuccessDataResult<List<Product>>(list);
        }

        public IDataResult<Product> GetByID(int productId)
        {
            var prod = _productDal.Get(filter: p => p.ProductId == productId);
            return new SuccessDataResult<Product>(prod);
        }

        public IDataResult<Product> GetProductByCategory(int categoryId)
        {
            var prod = _productDal.Get(filter: p => p.CategoryId == categoryId);
            return new SuccessDataResult<Product>(prod);
        }

        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.PRODUCT_ADDED);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.PRODUCT_DELETED);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.PRODUCT_UPDATED);
        }

    }
}
