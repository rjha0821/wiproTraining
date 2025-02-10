namespace ReportingSystem.Services
{
    public class ReportService
    {
        private readonly IReportGenerator _reportGenerator;
        private readonly IReportSaver _reportSaver;
        private readonly IReportFormatter _reportFormatter;

        public ReportService(IReportGenerator reportGenerator, IReportSaver reportSaver, IReportFormatter reportFormatter)
        {
            _reportGenerator = reportGenerator;
            _reportSaver = reportSaver;
            _reportFormatter = reportFormatter;
        }

        public void ProcessReport(string filename)
        {
            string reportData = _reportGenerator.GenerateReport();
            string formattedData = _reportFormatter.Format(reportData);
            _reportSaver.SaveReport(formattedData, filename);
        }
    }
}
