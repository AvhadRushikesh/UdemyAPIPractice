using Microsoft.AspNetCore.Identity;
using UdemyAPIPractice.Model.Users;

namespace UdemyAPIPractice.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);  // Create Or Register User
        Task<AuthResponseDto> Login(LoginDto loginDto);       // Login User
        Task<string> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
