using System;

// Method "Print" was added in this class because it is used in all derived classes.
namespace LabExam
{
    internal abstract class Printer //struct -> abstract class to add low coupling to code
    {
        public string Name { get; set; }

        public string Model { get; set; }

        // Rewrited due to using of exsisting event and reading with FileStream
        public void Print(object source, StartPrintEventArgs args)
        {
            args.FsStream.Position = 0;
            for (int i = 0; i < args.FsStream.Length; i++)
            {
                // simulate printing
                Console.Write(Convert.ToChar(args.FsStream.ReadByte()));
            }

            Console.WriteLine();
        }

        // Adding to array of Printers which will print out the file
        public void Register()
        {
            PrinterManager.StartPrint += Print;
        }

        // Deleting from array of Printers which will print out the file
        public void UnRegister()
        {
            PrinterManager.StartPrint -= Print;
        }
    }
}