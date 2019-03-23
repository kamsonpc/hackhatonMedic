using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HealthBack.Configuration.Dto;

namespace HealthBack.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HealthBackAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
