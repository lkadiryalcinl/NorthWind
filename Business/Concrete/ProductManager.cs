using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll(int categoryId)
        {
            return _productDal.GetList(filter: p => p.CategoryId == categoryId);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetByID(int productId)
        {
            var prod = _productDal.Get(filter: p => p.ProductId == productId);
            return prod;
        }

        public Product GetProductByCategory(int categoryId)
        {
            return _productDal.Get(filter:p => p.CategoryId == categoryId);
        }
    }
}
