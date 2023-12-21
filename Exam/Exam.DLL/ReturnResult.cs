using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.DLL
{
    public class ReturnResult<T>
    {

        public bool IsError { get; set; } = false;
        public string Message { get; set; }
        public Exception Exception { get; set; }
        public T Data { get; set; }
        public List<T> ListData { get; set; }

    }
}
