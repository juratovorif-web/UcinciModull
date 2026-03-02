using SocialMedia.Repositories;

namespace SocialMedia.Services;

public class TokenService : ITokenService
{
    private readonly IUserRepository UserRepository;
    public TokenService()
    {
        UserRepository = new UserRepository();
    }
    public (Guid userId, string role) GetTokenInfo(string token)
    {
        var userId = token.Substring(0, 36);
        var role = token.Substring(36);

        return (Guid.Parse(userId), role);
    }
}
