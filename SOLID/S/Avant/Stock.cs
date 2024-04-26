using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Avant
{
    // Implémentation de la classe de génération de rapport PDF (classe bas niveau car elle offre des fonctionnalité concrete)
    public class PDFReportGenerator
    {
        public void GeneratePDFReport(string data)
        {
            // Logique de génération du rapport PDF
            Console.WriteLine("Generating PDF report with data: " + data);
        }
    }

    // Classe de gestion de stock ( classe haut niveau car elle offre de fonctionnalités abstraites qui peuvent être utilisées par d'autres parties du système )
    public class StockManager
    {
        private PDFReportGenerator reportGenerator;

        public StockManager()
        {
            reportGenerator = new PDFReportGenerator();
        }

        public void GenerateStockReport(string data)
        {
            // Logique de génération de rapport
            reportGenerator.GeneratePDFReport(data);
        }
    }

   /* class Program
    {
        static void Main(string[] args)
        {
            StockManager stockManager = new StockManager();
            stockManager.GenerateStockReport("Stock data");
        }
    } */

}
