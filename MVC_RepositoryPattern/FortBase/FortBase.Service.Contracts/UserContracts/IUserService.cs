using FortBase.Common;
using FortBase.Service.Models.UserViewModels;

namespace FortBase.Service.Contracts.UserContracts
{
    public interface IUserService
    {
        ResultObject GetUsers();
        ResultObject SaveUser(UserVM userVM);
    }
}
