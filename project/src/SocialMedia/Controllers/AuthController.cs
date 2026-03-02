using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SocialMedia.Dtos;
using SocialMedia.Services;

namespace SocialMedia.Controllers;


[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly IAuthService AuthService;
    public AuthController()
    {
        AuthService = new AuthService();
    }

    [HttpPost("register")]
    public Guid Register(UserRegisterDto userRegisterDto)
    {
        return AuthService.RegisterUser(userRegisterDto);
    }

    [HttpPost("login")]
    public string Login(UserLoginDto userLoginDto)
    {
        return AuthService.LoginUser(userLoginDto);
    }
}
