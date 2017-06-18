# Xamarin Azure REST CatsLibrary Exemplo com Easy tables
###### :lock: Esse projeto foi construido com base no Visual Studio 2017 !!
###### :floppy_disk:[Download zipado](https://github.com/Vinicioslc/Xamarin-Azure-Exemplo-Easy-Tables-REST-Cats-Library/releases/tag/1.0)
Um exemplo de aplicação RESTful utilizando xamarin cross platform, Android, IOS, Com uma ligação ao Azure AppService.

Caso o server do azure não esteja dando retorno dos dados para o App, Crie o seu Servidor adicione suas Easy Tables.
E substitua a URI de conexão de dados do azure pela sua no Arquivo AzureServices.cs:

[...Cats\Cats\Cats\Services\AzureServices.cs]

```cs

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;

namespace Cats.Services
{
    class AzureServices<T>
    {
        //Substitua pelo link do seu azure app service
        const string appuri = "http://catsexample.azurewebsites.net";

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

```
