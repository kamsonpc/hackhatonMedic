using System.Threading.Tasks;
using Abp.Application.Services;
using HealthBack.Sessions.Dto;

namespace HealthBack.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
