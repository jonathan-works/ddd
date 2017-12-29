using JWorks.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWorks.Domain.Interface.Service
{
    public interface IUserService : IServiceBase<UserEntity>
    {
        IEnumerable<UserEntity> GetUserMaster(IEnumerable<UserEntity> user);
    }
}
