using Abp.Web.Mvc.Controllers;

namespace AplicacoesWeb.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class AplicacoesWebControllerBase : AbpController
    {
        protected AplicacoesWebControllerBase()
        {
            LocalizationSourceName = AplicacoesWebConsts.LocalizationSourceName;
        }
    }
}