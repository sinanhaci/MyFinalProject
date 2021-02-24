using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için bailangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
