using System.IO;

namespace LabExam
{
    public class LogToFile : ILogger
    {
        public void Log(string str)
        {
            File.AppendText("log.txt").Write(str);
        }
    }
}