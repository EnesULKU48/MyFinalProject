using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult //sende IResult var ve bunlar da var
    {
        T Data { get; }

    }
}
