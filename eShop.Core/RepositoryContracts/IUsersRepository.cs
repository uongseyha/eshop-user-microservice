using eShop.Core.DTO;
using eShop.Core.Entities;

namespace eShop.Core.RepositoryContracts;

public interface IUsersRepository
{
  Task<ApplicationUser?> AddUser(ApplicationUser user);
  Task<ApplicationUser?> GetUserByEmailAndPassword(string? email, string? password);
  Task<ApplicationUser?> GetUserByUserID(Guid? userID);
}
