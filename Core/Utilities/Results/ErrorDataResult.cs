using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorSuccessDataResult<T> : DataResult<T>
    {
        public ErrorSuccessDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorSuccessDataResult(T data) : base(data, false)
        {

        }
        public ErrorSuccessDataResult(string message) : base(default, false, message)
        {

        }
        public ErrorSuccessDataResult() : base(default, false)
        {

        }
    }
}
