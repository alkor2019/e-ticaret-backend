using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_Ticaret.Application.Abstractions.Results;

namespace E_Ticaret.Application.Abstractions.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data  { get; }
        public DataResult(T data, string message, bool success) : base(message, success)
        {
              Data = data;
        }

        
    }
}