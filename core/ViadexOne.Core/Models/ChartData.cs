using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViadexOne.Core.Models
{
    public class ChartData
    {
        public string[] Labels { get; set; }
        public Dataset[] Datasets { get; set; }
    }
}
