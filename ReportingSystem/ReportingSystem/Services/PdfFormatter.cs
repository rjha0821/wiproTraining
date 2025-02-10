namespace ReportingSystem.Services
{
    public class PdfFormatter : IReportFormatter
    {
        public string Format(string data)
        {
            return $"PDF Format: {data}";
        }
    }
}
