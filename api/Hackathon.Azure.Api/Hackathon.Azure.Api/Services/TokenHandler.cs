using Hackathon.Azure.Api.Services.Interfaces;
using Microsoft.IdentityModel.Clients.ActiveDirectory;

namespace Hackathon.Azure.Api.Services
{
    public class TokenHandler : ITokenHandler
    {
        public async Task<string> GetToken()
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
