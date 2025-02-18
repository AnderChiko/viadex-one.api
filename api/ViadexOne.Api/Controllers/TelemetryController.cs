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
        [HttpGet("devices")]
        public async Task<DeviceResponse> Get()
        {
            return await _telemetryService.GetDevices();
        }

        /// <summary>
        /// Experience Data
        /// </summary>
        /// <returns></returns>
        [HttpGet("device-metrics")]
        public async Task<TelemetryResponse> DevicesUsage()
        {
            return await _telemetryService.GetDeviceData();
        }
    }
}
