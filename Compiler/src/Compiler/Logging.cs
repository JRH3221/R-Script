using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler
{
    public class CustomException : Exception
    {
        public string? Message; 
        public Code ErrorCode;
        public CustomException(string? message, Code code = Code.Null)
        {
            Message = message;
            ErrorCode = code;
        }
    }
    public enum Code { Null = 0, PathError = 1, EmptyFile = 2, InvalidTarget = 3}
    internal class Logging
    {
        public static void Log(string? message = null, Code code = Code.Null)
        {
            string error = $"Error thrown with type '{code}'\r\nError message: '{message ?? "No Message"}'\r\n\r\n"; // double new line at the end

            if(!File.Exists("Log.txt"))
            {
                File.Create("Log.txt");
            }

            using(StreamWriter sw = new StreamWriter("Log.txt", true))
            {
                sw.WriteLine(error);
            }

            Console.Write(error);
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
