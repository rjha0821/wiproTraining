using System.IO;

namespace ReportingSystem.Services
{
    public class ReportSaver : IReportSaver
    {
        public void SaveReport(string data, string filename)
        {
            File.WriteAllText(filename, data);
        }
    }
}
