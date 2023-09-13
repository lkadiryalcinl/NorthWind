using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            this._customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CUSTOMER_ADDED);
        }

        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CUSTOMER_DELETED);
        }

        public IDataResult<List<Customer>> GetAll()
        {
            var list = _customerDal.GetList();
            return new SuccessDataResult<List<Customer>>(list);
        }

        public IDataResult<Customer> GetByID(string customerId)
        {
            var customer = _customerDal.Get(filter: c => c.CustomerId == customerId);
            return new SuccessDataResult<Customer>(customer);
        }

        public IResult Update(Customer customer)
        {
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CUSTOMER_UPDATED);
        }
    }
}
