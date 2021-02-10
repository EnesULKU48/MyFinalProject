using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç

    public interface IResult
    {
        bool Success { get; } //sadece (return yapar) okuma ---- başarı

        string Message { get; }
    }
}
