using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ResourceActions;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Azure1 = Microsoft.Azure.Management.Fluent.Azure;

namespace Hackathon.Azure.Business
{
    public class AuthorisationHandler
    {
        public static async Task<string> GetAuthorizationHeader()
        {
            AuthenticationResult? result;

            var context = new AuthenticationContext("https://login.windows.net/" + "93c16d38-d1d7-4702-ab62-e9d16603afe5");

            var resource = "https://login.microsoftonline.com/";
            
            var clientId = "0a0420fe-d6dd-4e74-8951-73cc71360dff";
            var clientSecret = "ntI8Q~AeVLrATOLZoHvbqMvOuBJb6wEjfXnHXdA4";

            var clientCred = new ClientCredential(clientId, clientSecret);


            try
            {
                result = await context.AcquireTokenAsync(resource, clientCred).ConfigureAwait(false);
            }
            catch (Exception)
            {
                throw;
            }
            
            var token = result.AccessToken;

            return token;
        }
    }
}

