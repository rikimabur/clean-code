namespace SOLID;

//Before
public class ReportGeneratorV1
{
    public void GenerateReport(string reportType)
    {
        if (reportType == "PDF")
        {
            // Generate a PDF report.
        }
        else if (reportType == "Excel")
        {
            // Generate an Excel report.
        }
    }
}

//After
public abstract class ReportGeneratorV2
{
    public abstract void GenerateReport();
}
public class PDFReportGenerator : ReportGeneratorV2
{
    public override void GenerateReport()
    {
        // Generate a PDF report.
    }
}
public class ExcelReportGenerator : ReportGeneratorV2
{
    public override void GenerateReport()
    {
        // Generate an Excel report.
    }
}