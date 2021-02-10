using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Result
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)// iki parametreli atarsa diğerine gerekli parametreyi atsın yoksa success iki kere çalışacak
        {
            Message = message;
        } 

        public Result(bool success)//tek parametreliyse zaten bu çalışacak
        {
            Success = success;
        }
        

        public bool Success { get; }

        public string Message { get; }
    }
}
