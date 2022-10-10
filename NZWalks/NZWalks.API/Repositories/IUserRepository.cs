namespace NZWalks.API.Repositories
{
    public interface IUserRepository
    {
        Task<bool> AuthenticateAsync(string userName, string password);
    }
}
