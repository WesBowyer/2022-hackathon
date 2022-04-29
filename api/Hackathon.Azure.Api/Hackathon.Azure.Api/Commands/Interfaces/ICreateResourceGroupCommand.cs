namespace Hackathon.Azure.Api.Commands.Interfaces
{
    public interface ICreateResourceGroupCommand
    {
        public Task<string> Execute(string resourceGroupName, string location);
    }
}
