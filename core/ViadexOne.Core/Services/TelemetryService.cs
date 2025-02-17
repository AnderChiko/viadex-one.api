using ViadexOne.Core.Models;
using ViadexOne.Core.Models.Responses;

namespace ViadexOne.Core.Services
{
    public class TelemetryService : ITelemetryService
    {
        public TelemetryService() { }

        //inherit doc
        public async Task<TelemetryResponse> GetDeviceTelemetry()
        {
            await Task.Delay(1);
            // sample data 
            var data = new ChartData
            {
                Labels = new[] { "CPU", "Memory", "Disk" },
                Datasets = new Dataset[]
               {
                    new Dataset
                    {
                        Label = "Usage (%)",
                        Data = new[] { 65, 45, 80 },
                        BackgroundColor = new[] { "#4F46E5", "#3B82F6", "#22C55E" }
                    }
               }
            };

            return new TelemetryResponse { Data = data };
        }

        //inherit doc
        public async Task<TelemetryResponse> GetExperienceData()
        {
            await Task.Delay(1);

            // sample data 
            var data = new ChartData
            {
                Labels = new[] { "Good", "Average", "Poor" },
                Datasets = new Dataset[]
                {
                    new Dataset
                    {
                        Data = new[] { 70, 20, 10 },
                        BackgroundColor = new[] { "#4ADE80", "#FACC15", "#EF4444" }
                    }
                }
            };

            return new TelemetryResponse { Data = data };
        }
    }
}
