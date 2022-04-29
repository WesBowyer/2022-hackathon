using Hackathon.Azure.Api.Commands.Interfaces;
using Hackathon.Azure.Api.Services.Interfaces;
using Microsoft.Azure.Management.Compute.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Hackathon.Azure.Api.Commands
{
    public class CreateResourceGroupCommand : ICreateResourceGroupCommand
    {
        private readonly ITokenHandler _tokenHandler;

        public CreateResourceGroupCommand(ITokenHandler tokenHandler)
        {
            _tokenHandler = tokenHandler;
        }
        public async Task<string> Execute(string resourceGroupName, string location)
        {
            var token = await _tokenHandler.GetToken().ConfigureAwait(false);
            var credential = new Microsoft.Rest.TokenCredentials(token);

            var x = new ResourceManager();
            //var httpClientHandler = new HttpClientHandler();

            //var handlers = new List<DelegatingHandler>();

            //var httpClient = new RestClient(httpClientHandler, handlers);

            //var x = new ResourceManagementClient(httpClient);
            //x.ResourceGroups.CreateOrUpdateAsync("")
        }
    }
}
