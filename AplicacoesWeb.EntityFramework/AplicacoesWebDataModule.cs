using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using AplicacoesWeb.EntityFramework;

namespace AplicacoesWeb
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(AplicacoesWebCoreModule))]
    public class AplicacoesWebDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<AplicacoesWebDbContext>(null);
        }
    }
}
