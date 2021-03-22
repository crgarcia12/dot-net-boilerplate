using System.Threading.Tasks;
using Abp.Application.Services;
using Contoso.Authorization.Accounts.Dto;

namespace Contoso.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
