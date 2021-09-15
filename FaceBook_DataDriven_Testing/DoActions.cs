using OpenQA.Selenium;

namespace FaceBook_DataDriven_Testing
{
    public class DoActions
    {
        public static void InputEmailAndPassword_into_InputFields(IWebDriver driver)
        {
            //Path of the file
            ExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\LoginData.xlsx");
            LoginPage login = new LoginPage(driver);
            //fetching data for email field
            login.email.SendKeys(ExcelOperation.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);

            //fetching data for password field
            login.password.SendKeys(ExcelOperation.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);

            //performing click operation for login button
            login.loginBtn.Click();
            System.Threading.Thread.Sleep(12000);
        }
    }
}
   