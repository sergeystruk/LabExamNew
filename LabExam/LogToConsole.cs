using System;

namespace LabExam
{
    public class LogToConsole : ILogger
    {
        public void Log(string str)
        {
            Console.WriteLine(str);
        }
    }
}