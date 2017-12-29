using JWorks.Domain.Entity;
using JWorks.Domain.Interface.Repository;

namespace JWorks.Infra.Data.Repository
{
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
    }
}
