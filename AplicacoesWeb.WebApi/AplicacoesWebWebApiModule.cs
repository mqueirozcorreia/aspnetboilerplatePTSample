using System.Reflection;
using Abp.Application.Services;
using Abp.Modules;
using Abp.WebApi;
using Abp.WebApi.Controllers.Dynamic.Builders;

namespace AplicacoesWeb
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AplicacoesWebApplicationModule))]
    public class AplicacoesWebWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AplicacoesWebApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
