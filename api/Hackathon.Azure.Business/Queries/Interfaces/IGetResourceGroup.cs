using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Azure.Business.Queries.Interfaces
{
    public interface IGetResourceGroup
    {
        Task<bool> Exists(string resourceGroup);
    } 
}
