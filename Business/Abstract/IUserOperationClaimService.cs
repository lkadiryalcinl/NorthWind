using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IDataResult<List<UserOperationClaim>> GetAll();
        IDataResult<UserOperationClaim> GetByID(int claimId);
        IResult Add(UserOperationClaim claim);
        IResult Update(UserOperationClaim claim);
        IResult Delete(UserOperationClaim claim);
    }
}
