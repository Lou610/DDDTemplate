using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assessment.Controllers
{
    [EnableCors("Assessment")]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class MainController : ControllerBase
    {
        [EnableCors("CoFlo")]
        [HttpGet]
        [Route("Home")]
        [MapToApiVersion("1.0")]
        public bool Home()
        {
            return true;
        }

    }
}
