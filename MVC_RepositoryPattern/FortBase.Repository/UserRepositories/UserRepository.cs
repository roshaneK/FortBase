using FortBase.Repository.Contracts.UserContracts;
using FortBase.Repository.Models.UserModels;

namespace FortBase.Repository.UserRepositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(FortBaseDbContext eventzDbContext)
           : base(eventzDbContext)
        {
        }
    }
}
