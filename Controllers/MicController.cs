using System.Web.Http;

namespace MicMute.Controllers
{
    public class MicController : ApiController
    {
     
        [HttpGet]
        public string Toggle()
        {
            CentralUIDispatcher.ToggleMuteButton();
            return "toggled";
        }

  

  
    }
}
