using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HealthBack.Controllers
{
    public abstract class HealthBackControllerBase: AbpController
    {
        protected HealthBackControllerBase()
        {
            LocalizationSourceName = HealthBackConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
