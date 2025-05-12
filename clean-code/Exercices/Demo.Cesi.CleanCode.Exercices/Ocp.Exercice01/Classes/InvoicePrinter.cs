using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Exercice01.Classes
{
   public class PdfInvoicePrinter : IInvoicePrinter
{
    public void Print()
    {
        Console.WriteLine("Printing PDF Invoice...");
    }
}

public class ExcelInvoicePrinter : IInvoicePrinter
{
    public void Print()
    {
        Console.WriteLine("Printing Excel Invoice...");
    }
}

}
