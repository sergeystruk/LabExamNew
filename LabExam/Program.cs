using System;

// I could add the opportunity to print by exact printers, but had not enough time
namespace LabExam
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Select your choice:");
                Console.WriteLine("1:Add new Canon printer");
                Console.WriteLine("2:Add new Epson printer");
                Console.WriteLine("3:Print on all");
                
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1)
                {
                    CreatePrinterCanon();
                }

                if (key.Key == ConsoleKey.D2)
                {
                    CreatePrinterEpson();
                }

                if (key.Key == ConsoleKey.D3)
                {
                    Print();
                }
                
            } while (true);
        }

        private static void Print()
        {
            PrinterManager.Print();
        }
        
        private static void CreatePrinterCanon()
        {
            CanonPrinter canonPrinter = new CanonPrinter();
            canonPrinter.Register();
        }

        private static void CreatePrinterEpson()
        {
            EpsonPrinter epsonPrinter = new EpsonPrinter();
            epsonPrinter.Register();
        }
    }
}
