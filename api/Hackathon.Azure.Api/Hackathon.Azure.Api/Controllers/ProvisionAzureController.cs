using Hackathon.Azure.Business.Requests;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Management.Compute.Fluent;

namespace Hackathon.Azure.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProvisionAzureController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> ProvisionEnvironment([FromBody]AzureEnvironmentProvisionRequest azureEnvironmentProvisionRequest)
        {
            var token = Azure.Business.AuthorisationHandler.GetAuthorizationHeader();

            var credential = new Microsoft.Rest.TokenCredentials(token);


            return Ok();
        }

    }
}