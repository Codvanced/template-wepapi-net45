using System.Web.Http;

namespace NAME_REPLACE.WebMvcApp
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            IoCFrameworkConfig.Register(GlobalConfiguration.Configuration);
        }
    }
}