using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Cats.Services
{
    class AzureServices<T>
    {
        const string appuri = "http://callcatsapp.azurewebsites.net/";

        IMobileServiceClient serviceClient;
        IMobileServiceTable<T> serviceTable;

        public AzureServices()
        {
            serviceClient = new MobileServiceClient(appuri);
            serviceTable = serviceClient.GetTable<T>();
        }
        public Task<IEnumerable<T>> GetTable()
        {
            return serviceTable.ToEnumerableAsync();
        }
    }
}
