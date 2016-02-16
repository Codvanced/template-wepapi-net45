using System.Web.Mvc;
using System.Web.Routing;
using DryIoc.Mvc;
using NAME_REPLACE.Binding;
using IOC.FW.Core.Abstraction.Container.Binding;
using IOC.FW.ContainerManager.DryIoc;
using NAME_REPLACE.WebMvcApp.App_Start;
using System.Web.Http;
using DryIoc.WebApi;

namespace NAME_REPLACE.WebMvcApp
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            WebApiConfig.Register(GlobalConfiguration.Configuration);

            var adapter = new DryIocAdapter();
            
            var binders = new IBinding[]{
                new BusinessBinder(),
                new DaoBinder(),
                new SharedBinder(),
                new FrameworkBinder(),
            };

            foreach (var binder in binders)
                binder.SetBinding(adapter);

            var containerWithMvc = adapter
                ._container
                .WithWebApi(GlobalConfiguration.Configuration);
        }
    }
}