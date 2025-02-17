using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViadexOne.Core.Models;
using ViadexOne.Core.Models.Responses;

namespace ViadexOne.Core.Services
{
    public interface ITelemetryService
    {
        /// <summary>
        /// Get Device Telemetry
        /// </summary>
        /// <returns></returns>
        Task<TelemetryResponse> GetDeviceTelemetry();

        /// <summary>
        /// Get Experience Data
        /// </summary>
        /// <returns></returns>
        Task<TelemetryResponse> GetExperienceData();
    }
}
