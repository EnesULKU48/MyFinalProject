using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Constracter da set; yaptık
        public Result(bool success, string message):this(success) //this diyerek çağırdık
        {
            Message = message;
            //Success = success;  sildik çünkü mesej göndermek istemeyebilir
        }
        //overloading
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
