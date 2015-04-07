using System.Reflection;
using Abp.Modules;

namespace AplicacoesWeb
{
    [DependsOn(typeof(AplicacoesWebCoreModule))]
    public class AplicacoesWebApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //We must declare mappings to be able to use AutoMapper
            DtoMappings.Map();
        }
    }
}
