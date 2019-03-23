using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HealthBack.Authorization;

namespace HealthBack
{
    [DependsOn(
        typeof(HealthBackCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HealthBackApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HealthBackAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HealthBackApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
