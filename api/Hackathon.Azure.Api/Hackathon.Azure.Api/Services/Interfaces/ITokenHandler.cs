namespace Hackathon.Azure.Api.Services.Interfaces
{
    public interface ITokenHandler
    {
        Task<string> GetToken();
    }
}
