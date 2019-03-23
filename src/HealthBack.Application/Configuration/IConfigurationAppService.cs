using System.Threading.Tasks;
using HealthBack.Configuration.Dto;

namespace HealthBack.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
