using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDateResult<T> : DateResult<T>
    {
        public ErrorDateResult(T date, string message) : base(date, false, message)
        {

        }
        public ErrorDateResult(T date) : base(date, false)
        {

        }
        public ErrorDateResult(string message) : base(default, false, message)
        {

        }
        public ErrorDateResult() : base(default, false)
        {

        }
    }
}
