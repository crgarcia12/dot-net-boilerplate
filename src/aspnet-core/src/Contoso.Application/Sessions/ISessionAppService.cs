using System.Threading.Tasks;
using Abp.Application.Services;
using Contoso.Sessions.Dto;

namespace Contoso.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
