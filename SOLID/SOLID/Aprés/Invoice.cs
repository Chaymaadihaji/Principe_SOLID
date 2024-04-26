using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SOLID.Après
{
    public class Invoice
    {
        public int InvoiceNumber { get; private set; }
        public double Amount { get; private set; }

        public Invoice(int invoiceNumber, double amount)
        {
            this.InvoiceNumber = invoiceNumber;
            this.Amount = amount;
        }
    }
}
