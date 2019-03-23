using Abp.Authorization;
using HealthBack.Authorization.Roles;
using HealthBack.Authorization.Users;

namespace HealthBack.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
