using Abp.Application.Services;
using Contoso.MultiTenancy.Dto;

namespace Contoso.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

