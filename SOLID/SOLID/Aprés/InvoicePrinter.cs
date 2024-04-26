using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SOLID.Après
{
    public class InvoicePrinter
    {
        public void PrintInvoiceDetails(Invoice invoice)
        {
            Console.WriteLine("Numéro de facture : " + invoice.InvoiceNumber);
            Console.WriteLine("Montant : " + invoice.Amount);
            Console.ReadKey();
        }
    }
}

