using System.Web.Http;

namespace MicMute.WebApiControllers
{
    public class MicController : ApiController
    {
     
        [HttpGet]
        [Route("api/mic/toggle")]
        public object Toggle()
        {
            CentralUIDispatcher.ToggleMuteButton();
            return  new { Message = "Toggled" };
        }

  
    }
}
