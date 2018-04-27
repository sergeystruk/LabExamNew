using System;
using System.IO;
using System.Windows.Forms;

namespace LabExam
{
    internal static class PrinterManager
    {
        // We don't have to use custom delegate or event because we have exsisting event. We initialized event with anonymous method because
        // it would not be null and we can't remove anonymous method from event using -=.
        public static event EventHandler<StartPrintEventArgs> StartPrint = delegate(object source, StartPrintEventArgs args) { };
        // We added the opportunity to have different logers in our program. I use LogToConsole.
        public static ILogger Logger { get; set; }

        public static void Print()
        {
            Log("Print started");
            var o = new OpenFileDialog();
            o.ShowDialog();
            var f = File.OpenRead(o.FileName);
            OnStartPrint(null, new StartPrintEventArgs(f));
            Log("Print finished");
        }

        public static void Log(string s)
        {
            if (ReferenceEquals(Logger, null))
            {
                Logger = new LogToConsole();
            }

            Logger.Log(s);
        }

        private static void OnStartPrint(object source, StartPrintEventArgs args)
        {
            StartPrint(null, args);
        }
    }
}