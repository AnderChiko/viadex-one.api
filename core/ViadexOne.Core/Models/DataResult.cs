using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViadexOne.Core.Enums;

namespace ViadexOne.Core.Models
{
    public class DataResult<T>
    {
        public Status Status { get; set; }

        public T? Data { get; set; }

        public ErrorModel? Error { get; set; }

        //constructor
        public DataResult() { }

        //parametarised constructor
        public DataResult(T data)
        {
            this.Status = Status.Success;
            this.Data = data;
        }
    }
}
