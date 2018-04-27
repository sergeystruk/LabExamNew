using System;
using System.IO;

// Inheritance from "Printer" class added. So we can use the reference of "Printer" to create objects of different printers.
// Properties deleted because they are not overrided and do not hide the properties of abstract class.
// Method "Print" was deleted and put in base class because it is used in all derived classes
namespace LabExam
{
    internal class EpsonPrinter : Printer
    {
        public EpsonPrinter()
        {
            Model = "231";
            Name = "Epson";
        }
    }
}