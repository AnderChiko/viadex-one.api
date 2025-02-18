using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViadexOne.Core.Models
{
   public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CpuUsage { get; set; }
        public int MemoryUsage { get; set; }
        public int DiskUsage { get; set; }
        public bool EncryptionEnabled { get; set; }
        public bool PolicyCompliant { get; set; }

        public List<ResourceUsage> ResourceUsages { get; set; } = [];
    }
}
