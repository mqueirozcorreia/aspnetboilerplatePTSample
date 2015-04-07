using Abp.Application.Services;

namespace AplicacoesWeb
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class AplicacoesWebAppServiceBase : ApplicationService
    {
        protected AplicacoesWebAppServiceBase()
        {
            LocalizationSourceName = AplicacoesWebConsts.LocalizationSourceName;
        }
    }
}