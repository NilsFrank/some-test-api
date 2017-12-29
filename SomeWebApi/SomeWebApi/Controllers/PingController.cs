using System.Web.Http;

namespace SomeWebApi.Controllers
{
    public class PingController : ApiController
    {
        [HttpGet]
        [Route("ping/isalive")]
        public IHttpActionResult Get_IsAlive()
        {
            return Ok("Im Alive!");
        }
    }
}