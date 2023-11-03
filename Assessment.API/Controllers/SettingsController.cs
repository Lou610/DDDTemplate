using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Assessment.BusinessApplicationLayer.Repository.SET.Interface;

namespace Assessment.API.Controllers
{
    [EnableCors("Assessment")]
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiExplorerSettings(GroupName = "v1")]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsService _repository;

        public SettingsController(ISettingsService repository)
        {
            _repository = repository;
        }

        [EnableCors("Assessment")]
        [HttpGet]
        [Route("GetSetting")]
        [MapToApiVersion("1.0")]
        public async Task<IActionResult> GetSetting(int settingsID)
        {
            try
            {
               var set = await _repository.GetSettingsbyIDAsync(settingsID);
                return Ok(set);

            }
            catch (Exception ex)
            {
                // Log the exception details
                // Return an appropriate error response
                return StatusCode(500, "An error occurred while retrieving settings.");


            }
        }
    }
}
