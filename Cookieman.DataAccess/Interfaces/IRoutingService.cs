using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookieman.DataAccess.Interfaces
{
    public interface IRoutingService
    {
        CookieContext GetRoutedContext(Guid storeId);

        void SyncStoresToDatabases();
    }
}
