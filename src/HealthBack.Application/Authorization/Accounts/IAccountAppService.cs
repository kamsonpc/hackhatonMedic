using System.Threading.Tasks;
using Abp.Application.Services;
using HealthBack.Authorization.Accounts.Dto;

namespace HealthBack.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
