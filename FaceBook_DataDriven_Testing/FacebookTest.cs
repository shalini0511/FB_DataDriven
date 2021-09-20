/* Project = Automating Facebook using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
using NUnit.Framework;

namespace FaceBook_DataDriven_Testing
{

    public class FaceBookTest:BaseClass.BaseClass1
    {

        ExtentReports report = FaceBookReport.report();
        ExtentTest test;


        [Test]
        public void Test1()
        {
            test = report.CreateTest("FaceBookTest");
            test.Log(Status.Info, "Facebook Automation");
            DoActions.InputEmailAndPassword_into_LoginInputFields(driver);
            test.Log(Status.Pass, "TestCases Passed");
            report.Flush();

        }

    }
}
