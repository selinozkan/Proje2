using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDateResult<T>:DateResult<T>
    {
        public SuccessDateResult(T date ,string message ):base(date,true,message)
        {

        }
        public SuccessDateResult(T date):base(date ,true)
        {

        }
        public SuccessDateResult(string message) : base(default ,true, message)
        {

        }
        public SuccessDateResult() : base(default, true)
        {

        }
    }
}
