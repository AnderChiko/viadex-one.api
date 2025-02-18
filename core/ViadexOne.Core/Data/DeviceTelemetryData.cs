using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViadexOne.Core.Models;

namespace ViadexOne.Core.Data
{
    public static class DeviceTelemetryData
    {
        public static readonly List<Device> DevicesTelemetry = new()
        {
            new Device { Id = 1, Name = "Laptop-001", CpuUsage = 35, MemoryUsage = 65, DiskUsage = 60, EncryptionEnabled = true, PolicyCompliant = true,
            ResourceUsages = new List<ResourceUsage>
               {
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:00:00"), CpuUsage = 5.5,  MemoryUsage = 51.2, DiskUsage = 15.00},
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:05:00"), CpuUsage = 30.2, MemoryUsage = 60.0, DiskUsage = 16.00},
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:10:00"), CpuUsage = 45.1, MemoryUsage = 75.0, DiskUsage = 17.00},
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:15:00"), CpuUsage = 50.3, MemoryUsage = 80.0, DiskUsage = 18.00},
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:20:00"), CpuUsage = 40.0, MemoryUsage = 70.0, DiskUsage = 17.50},
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:25:00"), CpuUsage = 35.4, MemoryUsage = 65.0, DiskUsage = 16.50},
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:30:00"), CpuUsage = 60.2, MemoryUsage = 90.0, DiskUsage = 19.00},
                  new ResourceUsage{ Date = DateTime.Parse("2025-02-18 00:35:00"), CpuUsage = 55.1, MemoryUsage = 85.0, DiskUsage = 18.50 }

               }
            },
            new Device { Id = 2, Name = "Laptop-002", CpuUsage = 50, MemoryUsage = 80, DiskUsage = 45, EncryptionEnabled = false, PolicyCompliant = false },
            new Device { Id = 3, Name = "Laptop-003", CpuUsage = 60, MemoryUsage = 50, DiskUsage = 40, EncryptionEnabled = false, PolicyCompliant = false },
            new Device { Id = 4, Name = "Laptop-004", CpuUsage = 70, MemoryUsage = 70, DiskUsage = 90, EncryptionEnabled = false, PolicyCompliant = false },
            new Device { Id = 5, Name = "Laptop-005", CpuUsage = 80, MemoryUsage = 60, DiskUsage = 75, EncryptionEnabled = false, PolicyCompliant = false },
            new Device { Id = 6, Name = "Laptop-006", CpuUsage = 90, MemoryUsage = 90, DiskUsage = 50, EncryptionEnabled = false, PolicyCompliant = false },
            new Device { Id = 7, Name = "Laptop-007", CpuUsage = 50, MemoryUsage = 40, DiskUsage = 32, EncryptionEnabled = false, PolicyCompliant = false }

        };
    }
}
