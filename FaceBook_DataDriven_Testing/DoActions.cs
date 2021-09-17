using System;
using ExcelDataReader.Log;
using NUnit.Framework;
using OpenQA.Selenium;

namespace FaceBook_DataDriven_Testing
{
    public class DoActions:BaseClass.BaseClass1
    {
        public static void InputEmailAndPassword_into_LoginInputFields(IWebDriver driver)
        {
            //Path of the file
            ExcelOperation.PopulateInCollection(@"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\LoginData.xlsx");
            LoginPage login = new LoginPage(driver);
            //fetching data for email field
            login.email.SendKeys(ExcelOperation.ReadData(1, "email"));
            System.Threading.Thread.Sleep(2000);
            ScreenShot();
            try
            {
                log.Info("email entered");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }


            //fetching data for password field
            login.password.SendKeys(ExcelOperation.ReadData(1, "password"));
            System.Threading.Thread.Sleep(2000);
            ScreenShot();

            try
            {
                log.Info("Password entered");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            //performing click operation for login button
            login.loginBtn.Click();
            System.Threading.Thread.Sleep(12000);
            ScreenShot();
            try
            {
                log.Info("Logged in successfully");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }



        }


       
        //Method for ScreenShot
        public static void ScreenShot()
        {
            ITakesScreenshot screenshotDriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotDriver.GetScreenshot();
            screenshot.SaveAsFile(@"C:\Users\HP\source\repos\FaceBook_DataDriven_Testing\FaceBook_DataDriven_Testing\Screenshot\" + DateTime.Now.ToString("hhmmss") + ".png");



        }

    }
}
   