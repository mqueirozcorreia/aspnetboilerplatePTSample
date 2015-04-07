using System.Reflection;
using Abp.Modules;

namespace AplicacoesWeb
{
    public class AplicacoesWebCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
