using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

public class ExtentManager
{

    private static ExtentReports extent;
    private static ExtentHtmlReporter htmlReporter;

    public static ExtentReports GetReporter()
    {
        if (extent == null)
        {
         
            string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
            string reportPath = $"C:\\TestData\\ExtentReport_{timestamp}.html";
            // string reportDirectory = $"C:\\TestData\\TestRun_{timestamp}\\";
            var htmlReporter = new ExtentV3HtmlReporter(reportPath);
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
            extent.AddSystemInfo("Host Name", "Local host");
            extent.AddSystemInfo("Environment", "Production");
            extent.AddSystemInfo("Username", "dpatel");
        }
        return extent;
    }
}
