using BookStoreApi.Blazor.WebAssembly.UI.Services.Base;

namespace BookStoreApi.Blazor.WebAssembly.UI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
