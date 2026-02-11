using eCommerce.Core.Validators;
using eShop.Core.ServiceContracts;
using eShop.Core.Services;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace eShop.Core
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
      services.AddTransient<IUsersService, UsersService>();
      services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();
      services.AddValidatorsFromAssemblyContaining<RegisterRequestValidator>();
      return services;
    }
  }
}
