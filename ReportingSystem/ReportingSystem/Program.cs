using System;
using ReportingSystem.Services;

class Program
{
    static void Main()
    {
        // Using Dependency Injection
        IReportGenerator generator = new ReportGenerator();
        IReportSaver saver = new ReportSaver();
        IReportFormatter formatter = new PdfFormatter(); // Swap with ExcelFormatter if needed

        ReportService reportService = new ReportService(generator, saver, formatter);
        reportService.ProcessReport("report.pdf");

        Console.WriteLine("Report processed and saved successfully.");
    }
}
