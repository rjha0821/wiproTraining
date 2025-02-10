namespace ReportingSystem.Models
{
    public class GraphicalReport : Report
    {
        public override string GetContent()
        {
            return "Graphical Report with Charts";
        }
    }
}
