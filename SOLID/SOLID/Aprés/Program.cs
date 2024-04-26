using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID.Après
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Invoice myInvoice = new Invoice(12345, 100.50);
            InvoicePrinter printer = new InvoicePrinter();
            printer.PrintInvoiceDetails(myInvoice);
        }
    }
}
