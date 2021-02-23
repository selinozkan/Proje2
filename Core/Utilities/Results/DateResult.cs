using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DateResult<T> : Result, IDateResult<T>
    {
        public DateResult(T date ,bool success,string message):base(success,message)
        {
            Date = date;
        }
        public DateResult(T date ,bool success ):base(success)
        {
            Date = date;

        }
        public T Date { get; }
    }
}
