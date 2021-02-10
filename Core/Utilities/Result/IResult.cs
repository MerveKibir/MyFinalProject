using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
