/* Project = Automating Facebook
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

namespace FaceBook_DataDriven_Testing
{
    [TestFixture]
    public class FaceBookReport
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;
        public static ExtentTest test;



        public static ExtentReports report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\Reports\Facebook.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "shalini");
                extent.AddSystemInfo("ProviderName", "shalini");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "Facebook Automation");



                string conifgPath = @"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\extent-config.xml";
                htmlReporter.LoadConfig(conifgPath);
            }
            return extent;

        }
    }
}
