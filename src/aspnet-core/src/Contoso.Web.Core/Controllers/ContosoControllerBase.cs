using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Contoso.Controllers
{
    public abstract class ContosoControllerBase: AbpController
    {
        protected ContosoControllerBase()
        {
            LocalizationSourceName = ContosoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
