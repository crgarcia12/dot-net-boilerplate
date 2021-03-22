using Abp.Authorization;
using Contoso.Authorization.Roles;
using Contoso.Authorization.Users;

namespace Contoso.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
