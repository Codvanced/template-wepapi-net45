using NAME_REPLACE.Abstraction.Business;
using System.Web.Http;

namespace NAME_REPLACE.WebMvcApp.Controllers
{
    public class HomeController : ApiController
    {
        private readonly ISampleBusiness _business;

        public HomeController(ISampleBusiness business)
        {
            _business = business;
        }

        public string Get()
        {
            return "Hello, world!";
        }
    }
}
