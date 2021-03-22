using System.Threading.Tasks;
using Contoso.Configuration.Dto;

namespace Contoso.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
