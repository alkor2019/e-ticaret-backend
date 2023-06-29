using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Application.Abstractions.Results
{
    public interface IDataResult<T> : IResult
    {
         T Data { get; }

    }
}