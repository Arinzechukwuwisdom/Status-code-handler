using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    internal class Method
    {
        string message = "Informational";
        int code = 100;
        // ResponseHeader = code + codeName;

        Console.WriteLine(ResponseHeader);
        static void GetStatusCode(string message, int code)
        {
            Console.WriteLine("Your http request is " + code + codeName);
        }
    }
}
