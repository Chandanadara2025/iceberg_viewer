namespace auth_service.Services
{
    public interface IAuthService
    {
        string Authenticate(string username, string password);
    }
}
