using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Abstractions.Results
{
    public class Result : IResult
    {
        public string Message { get; }
        public bool Success { get; }

        public Result(string message, bool success):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
    }
}