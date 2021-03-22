using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Contoso.Configuration.Dto;

namespace Contoso.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ContosoAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
