using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult(Messages.EMPLOYEE_ADDED);
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.EMPLOYEE_DELETED);
        }

        public IDataResult<List<Employee>> GetAll()
        {
            var list = _employeeDal.GetList();
            return new SuccessDataResult<List<Employee>>(list);
        }

        public IDataResult<Employee> GetByID(int employeeId)
        {
            var employee = _employeeDal.Get(filter: e => e.EmployeeId == employeeId);
            return new SuccessDataResult<Employee>(employee);
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.EMPLOYEE_UPDATED);
        }
    }
}
