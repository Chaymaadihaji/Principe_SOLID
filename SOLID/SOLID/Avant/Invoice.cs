using System;

namespace SOLID.Avant
{


    public class Invoice
    {
        private int invoiceNumber;
        private double amount;

        public Invoice(int invoiceNumber, double amount)
        {
            this.invoiceNumber = invoiceNumber;
            this.amount = amount;
        }

        public int GetInvoiceNumber()
        {
            return invoiceNumber;
        }

        public double GetAmount()
        {
            return amount;
        }

        public void PrintInvoiceDetails()
        {
            Console.WriteLine("Numéro de facture : " + GetInvoiceNumber());
            Console.WriteLine("Montant : " + GetAmount());
            Console.ReadKey();
        }
    }

    /*public class Program
    {
        public static void Main1(string[] args)
        {
            Invoice myInvoice = new Invoice(12345, 100.50);
            myInvoice.PrintInvoiceDetails();
        }
    }
    */
}
