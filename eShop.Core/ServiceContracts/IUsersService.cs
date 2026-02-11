using eShop.Core.DTO;

namespace eShop.Core.ServiceContracts;

public interface IUsersService
{
  Task<AuthenticationResponse?> Login(LoginRequest loginRequest);
  Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
}
