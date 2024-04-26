using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S.Apres
{
    // Interface pour la génération de rapports
    public interface IReportGenerator
    {
        void GenerateReport(string data);
    }

    // Implémentation de la génération de rapport PDF
    public class PDFReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            // Logique de génération du rapport PDF
            Console.WriteLine("Generating PDF report with data: " + data);
            Console.ReadKey();
        }
    }

    // Classe de gestion de stock
    public class StockManager
    {
        private readonly IReportGenerator reportGenerator;

        public StockManager(IReportGenerator reportGenerator)
        {
            this.reportGenerator = reportGenerator;
        }

        public void GenerateStockReport(string data)
        {
            // Logique de génération de rapport
            reportGenerator.GenerateReport(data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IReportGenerator pdfReportGenerator = new PDFReportGenerator();
            StockManager stockManager = new StockManager(pdfReportGenerator);
            stockManager.GenerateStockReport("Stock data");
        }
    }

}
