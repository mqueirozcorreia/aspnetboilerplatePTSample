using System.Web.Mvc;

namespace AplicacoesWeb.Web.Controllers
{
    public class HomeController : AplicacoesWebControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}