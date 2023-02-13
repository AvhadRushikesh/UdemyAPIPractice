using Microsoft.AspNetCore.Identity;
using UdemyAPIPractice.Model.Users;

namespace UdemyAPIPractice.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto);  // Create Or Register User
        Task<bool> Login(LoginDto loginDto);       // Login User
    }
}
