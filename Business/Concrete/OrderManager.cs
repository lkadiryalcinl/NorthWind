using Business.Abstract;
using Business.Constants;
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
            _orderDal.Add(order);
            return new SuccessResult(Messages.ORDER_ADDED);
        }

        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult(Messages.ORDER_DELETED);
        }

        public IDataResult<List<Order>> GetAll()
        {
            var list = _orderDal.GetList();
            return new SuccessDataResult<List<Order>>(list);
        }

        public IDataResult<List<Order>> GetAll(string customerId)
        {
            var list = _orderDal.GetList(filter: o => o.CustomerId == customerId);
            return new SuccessDataResult<List<Order>>(list);
        }

        public IDataResult<List<Order>> GetAll(int employeeId)
        {
            var list = _orderDal.GetList(filter: p => p.EmployeeId == employeeId);
            return new SuccessDataResult<List<Order>>(list);
        }

        public IDataResult<Order> GetByID(int orderId)
        {
            var order = _orderDal.Get(filter: o => o.OrderId == orderId);
            return new SuccessDataResult<Order>(order);
        }

        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult(Messages.ORDER_UPDATED);
        }
    }
}
