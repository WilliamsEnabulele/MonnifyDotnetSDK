namespace MonnifyDotnet.SDK.Interfaces
{
    public interface IAuthService
    {
        Task<string> GetAccessTokenAsync();
    }
}