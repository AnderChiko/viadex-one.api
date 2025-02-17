using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViadexOne.Core.Models
{
    public class Dataset
    {
        public string Label { get; set; }
        public int[] Data { get; set; }
        public string[] BackgroundColor { get; set; }

    }
}
