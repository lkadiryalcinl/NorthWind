using Business.Abstract;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private readonly IUserOperationClaimDal _userOperationClaim;

        public UserOperationClaimManager(IUserOperationClaimDal userOperationClaim)
        {
            _userOperationClaim = userOperationClaim;
        }

        public IResult Add(UserOperationClaim claim)
        {
            _userOperationClaim.Add(claim);
            return new SuccessResult();
        }

        public IResult Delete(UserOperationClaim claim)
        {
            _userOperationClaim.Delete(claim);
            return new SuccessResult();
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            var list = _userOperationClaim.GetList();
            return new SuccessDataResult<List<UserOperationClaim>>(list);
        }

        public IDataResult<UserOperationClaim> GetByID(int claimId)
        {
            var claim = _userOperationClaim.Get(filter: c => c.Id == claimId);
            return new SuccessDataResult<UserOperationClaim>(claim);
        }

        public IResult Update(UserOperationClaim claim)
        {
            _userOperationClaim.Update(claim);
            return new SuccessResult();
        }
    }
}
