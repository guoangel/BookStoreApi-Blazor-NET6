using BookStoreApi.Blazor.Server.UI.Services.Base;

namespace BookStoreApi.Blazor.Server.UI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<Response<AuthResponse>> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
