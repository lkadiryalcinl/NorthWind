using Core.Entities.Concrete;
using Core.Utilities.Security.Core;
using Entities.Concrete;

namespace Core.Utilities.Security.Helpers
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
