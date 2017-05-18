using Cookieman.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookieman.DataAccess.Interfaces
{
    public interface IAccountService
    {
        Task<Guid> GetStoreIdFromUser(string userId);
        void RegisterNewStoreAndUser(Register storeAndUserData);

        Task<string> CreateNewUser(Register userInfo, string storeId);
    }
}
