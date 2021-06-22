using System;
using System.Collections.Generic;
using System.Text;

namespace ErrorHandling
{
    public class MyCustomException : Exception
    {
        public MyCustomException(string message) : base(message)
        {

        }
    }
}
