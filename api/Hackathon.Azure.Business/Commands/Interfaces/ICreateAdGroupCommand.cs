using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Azure.Business.Commands.Interfaces
{
    public interface ICreateAdGroupCommand
    {
        Task Execute(string displayName, string nickName);
    }
}
