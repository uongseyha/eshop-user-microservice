using eShop.Core.DTO;
using eShop.Core.Entities;

namespace eShop.Core.ServiceContracts;

public interface IUsersService
{
  Task<AuthenticationResponse?> Login(LoginRequest loginRequest);
  Task<AuthenticationResponse?> Register(RegisterRequest registerRequest);
  Task<UserDTO> GetUserByUserID(Guid userID);
}
