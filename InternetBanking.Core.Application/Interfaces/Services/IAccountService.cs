using InternetBanking.Core.Application.Dtos.Account;

namespace InternetBanking.Core.Application.Interfaces.Services
{
    public interface IAccountService
    {
        Task<AuthenticationResponse> AuthenticationAsync(AuthenticationRequest request);
        Task<RegisterResponse> RegisterAdminUserAsync(RegisterRequest request);
        Task<RegisterResponse> RegisterWaiterUserAsync(RegisterRequest request);
    }
}