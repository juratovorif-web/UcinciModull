using SocialMedia.Dtos;

namespace SocialMedia.Services;

public interface IAuthService
{
    public Guid RegisterUser(UserRegisterDto userRegisterDto);
    public string LoginUser(UserLoginDto userLoginDto);
}