using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public IResult Add(Order order)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAll(string customerId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAll(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> GetByID(int orderId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
