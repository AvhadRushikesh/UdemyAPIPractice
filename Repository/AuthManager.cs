using AutoMapper;
using Microsoft.AspNetCore.Identity;
using UdemyAPIPractice.Contracts;
using UdemyAPIPractice.Data;
using UdemyAPIPractice.Model.Users;

namespace UdemyAPIPractice.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
        {
            this._mapper = mapper;
            this._userManager = userManager;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            // Login Logic
            // This Method Validate that the use exists in the System
            bool isValidUser = false;

            try
            {
                var user = await _userManager.FindByEmailAsync(loginDto.Email); //  Finde User Name
                isValidUser = await _userManager.CheckPasswordAsync(user, loginDto.Password); //  Find Password
            }
            catch (Exception)
            {
            }
            //  If found Successfully return true else false
            return isValidUser;

            #region Fix Login Logic
            /*
             * If the _user object comes back as null, this will lead to a null
             * exception in the CheckPasswordAsync() method. We can
             * refactor like this:
             * 
             _user = await _userManager.FindByEmailAsync(loginDto.EmailAddress);
             if (_user is null)
             {
                 return default;
             }
 
             bool isValidCredentials = await _userManager.CheckPasswordAsync(_user, loginDto.Password);
 
             if (!isValidCredentials)
             {
                 return default;
             }
             */
            #endregion
        }

        public async Task<IEnumerable<IdentityError>> Register(ApiUserDto userDto)
        {
            var user = _mapper.Map<ApiUser>(userDto);
            user.UserName = userDto.Email;

            var result = await _userManager.CreateAsync(user, userDto.Password);

            if(result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }
    }
}
