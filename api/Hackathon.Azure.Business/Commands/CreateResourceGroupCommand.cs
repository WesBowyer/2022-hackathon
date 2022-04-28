using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Azure.ResourceManager;
using Hackathon.Azure.Business.Commands.Interfaces;

namespace Hackathon.Azure.Business.Commands
{
    public class CreateResourceGroupCommand : ICreateResourceGroupCommand
    {
        public Task Execute(string resourceGroupName, string location)
        {
            throw new NotImplementedException();
        }
    }
}
