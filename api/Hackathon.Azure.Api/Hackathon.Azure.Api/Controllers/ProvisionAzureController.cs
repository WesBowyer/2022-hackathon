using Hackathon.Azure.Business.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Hackathon.Azure.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProvisionAzureController : ControllerBase
    {

        [HttpPost]
        public Task<IActionResult> ProvisionEnvironment([FromBody]AzureEnvironmentProvisionRequest azureEnvironmentProvisionRequest)
        {
            throw new NotImplementedException();
        }

    }
}