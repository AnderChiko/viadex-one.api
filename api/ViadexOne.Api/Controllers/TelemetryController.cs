using Microsoft.AspNetCore.Mvc;
using ViadexOne.Core.Models;
using ViadexOne.Core.Models.Responses;
using ViadexOne.Core.Services;

namespace ViadexOne.Api.Controllers
{
    [ApiController]
    [Route("api/telemetry")]
    public class TelemetryController : ControllerBase
    {
        private readonly ITelemetryService _telemetryService;
        public TelemetryController(ITelemetryService telemetryService)
        {
            this._telemetryService = telemetryService;
        }

        /// <summary>
        /// Get Device Telemetry
        /// </summary>
        /// <returns></returns>
        [HttpGet("device-telemetry")]
        public async Task<TelemetryResponse> Get()
        {
            return await _telemetryService.GetDeviceTelemetry();
        }

        /// <summary>
        /// Experience Data
        /// </summary>
        /// <returns></returns>
        [HttpGet("experience-data")]
        public async Task<TelemetryResponse> ExperienceData()
        {
            return await _telemetryService.GetExperienceData();
        }
    }
}
