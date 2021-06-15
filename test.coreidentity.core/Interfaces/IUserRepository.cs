using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using test.coreidentity.core.Models;

namespace test.coreidentity.core.Interfaces
{
    public interface IUserRepository
    {
        Task AddUser(UserInfo userInfo);

        Task AddUsers();
    }
}
