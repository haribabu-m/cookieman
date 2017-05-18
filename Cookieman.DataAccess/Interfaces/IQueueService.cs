using Cookieman.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookieman.DataAccess.Interfaces
{
    public interface IQueueService
    {
        void QueueNewStoreCreation(string userAndStoreData);
    }
}
