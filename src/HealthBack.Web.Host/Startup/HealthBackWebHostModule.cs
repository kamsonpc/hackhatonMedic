using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HealthBack.Configuration;

namespace HealthBack.Web.Host.Startup
{
    [DependsOn(
       typeof(HealthBackWebCoreModule))]
    public class HealthBackWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HealthBackWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HealthBackWebHostModule).GetAssembly());
        }
    }
}
