using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HealthBack.MultiTenancy.Dto;

namespace HealthBack.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

