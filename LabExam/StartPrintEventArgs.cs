using System;
using System.IO;

namespace LabExam
{
    public class StartPrintEventArgs : EventArgs
    {
        public FileStream FsStream { get; set; }

        public StartPrintEventArgs(FileStream fs)
        {
            FsStream = fs;
        }
    }
}