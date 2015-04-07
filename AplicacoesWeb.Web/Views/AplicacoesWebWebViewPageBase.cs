using Abp.Web.Mvc.Views;

namespace AplicacoesWeb.Web.Views
{
    public abstract class AplicacoesWebWebViewPageBase : AplicacoesWebWebViewPageBase<dynamic>
    {

    }

    public abstract class AplicacoesWebWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected AplicacoesWebWebViewPageBase()
        {
            LocalizationSourceName = AplicacoesWebConsts.LocalizationSourceName;
        }
    }
}