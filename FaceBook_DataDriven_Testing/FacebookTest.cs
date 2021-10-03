/* Project = Automating Facebook using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using AventStack.ExtentReports;
using NUnit.Framework;

namespace FaceBook_DataDriven_Testing
{

    public class FaceBookTest : BaseClass.BaseClass1
    {

        ExtentReports report = FaceBookReport.report();
        ExtentTest test;


        /*  [Test, Order(0)]
          public void LoginPage()
          {
              test = report.CreateTest("FaceBookTest");
              test.Log(Status.Info, "Facebook Automation");
              DoActions.InputEmailAndPassword_into_LoginInputFields(driver);
              System.Threading.Thread.Sleep(4000);
              ScreenShot();
              test.Info("Screenshots", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\Screenshots\test.jpg").Build());
              //DoAction.FileUploadDoActions.UploadingFile(driver);
              test.Log(Status.Pass, "TestCases Passed");
              report.Flush();

          }
          [Test, Order(1)]
          public void TestMethodFileUpload()
          {
              DoActions.UploadingFile(driver);
              System.Threading.Thread.Sleep(4000);
              ScreenShot();
              test.Info("Screenshots", MediaEntityBuilder.CreateScreenCaptureFromPath(@"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\Screenshots\test.jpg").Build());


          }*/
        [Test, Order(3)]
        public void TestMethodForLogout()
        {
            DoActions.Logout();
        }

       /* [Test, Order(2)]
        public void SendReportToMail()

        {
            GMail.Gmail.ReadDataFromExcel();
            GMail.Gmail.email_send();
        }*/
      




    }

   

}
