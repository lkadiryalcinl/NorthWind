using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly ICustomerDal _customerDal;

        public EmployeeManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Employee employee)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Employee>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Employee> GetByID(int employeeId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
