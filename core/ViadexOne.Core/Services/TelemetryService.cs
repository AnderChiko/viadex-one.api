using ViadexOne.Core.Data;
using ViadexOne.Core.Models;
using ViadexOne.Core.Models.Responses;

namespace ViadexOne.Core.Services
{
    public class TelemetryService : ITelemetryService
    {
        public TelemetryService() { }

        //inherit doc
        public async Task<DeviceResponse> GetDevices()
        {
            await Task.Delay(1);
            var listDevices = await Task.FromResult(DeviceTelemetryData.DevicesTelemetry);
            return new DeviceResponse { Entry = DeviceTelemetryData.DevicesTelemetry };
        }

        //inherit doc
        public async Task<TelemetryResponse> GetDeviceData()
        {
            // Simulate asynchronous work
            await Task.Delay(1);

            // Check if there are any telemetry data entries
            var telemetryData = DeviceTelemetryData.DevicesTelemetry;
            if (telemetryData == null || !telemetryData.Any())
            {
                // Handle the case where there are no telemetry data entries
                return new TelemetryResponse { Error = new ErrorModel { Message = "No device information." } }; 
            }

            // Return the first entry of telemetry data
            return new TelemetryResponse { Entry = telemetryData.First() };
        }
    }
}
