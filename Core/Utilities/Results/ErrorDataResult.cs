using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)//ister data ve mesaj ver
        {

        }

        public ErrorDataResult(T data) : base(data, false)//ister data ver
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)//ister mesaj ver
        {

        }

        public ErrorDataResult() : base(default, false)//ister hiç bi şey verme
        {

        }

    }
}
