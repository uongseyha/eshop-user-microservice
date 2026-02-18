using AutoMapper;
using eShop.Core.DTO;
using eShop.Core.Entities;
using eShop.Core.RepositoryContracts;
using eShop.Core.ServiceContracts;

namespace eShop.Core.Services;

internal class UsersService(IUsersRepository _usersRepository, IMapper _mapper) : IUsersService
{
    public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
    {
        ApplicationUser? user = await _usersRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);

        if (user == null)
        {
            return null;
        }

        return _mapper.Map<AuthenticationResponse>(user) with { Success = true, Token = "token" };
    }

    public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
    {
        ApplicationUser user= _mapper.Map<ApplicationUser>(registerRequest);
        ApplicationUser? registeredUser = await _usersRepository.AddUser(user);
        if (registeredUser == null)
        {
            return null;
        }

        return _mapper.Map<AuthenticationResponse>(registeredUser) with { Success = true, Token = "token"};
    }

  public async Task<UserDTO> GetUserByUserID(Guid userID)
  {
    ApplicationUser? user = await _usersRepository.GetUserByUserID(userID);
    return _mapper.Map<UserDTO>(user);
  }
}
