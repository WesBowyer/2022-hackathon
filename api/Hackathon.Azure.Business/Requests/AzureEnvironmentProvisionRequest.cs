using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hackathon.Azure.Business.Models;

namespace Hackathon.Azure.Business.Requests
{
    public class AzureEnvironmentProvisionRequest
    {
        public string EnvironmentCode { get; set; }

        public AzureEnvironmentProvision AzureEnvironmentProvision { get; set; }
    }
}
