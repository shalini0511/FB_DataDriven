/* Project = Automating Facebook using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using System;
using AutoItX3Lib;
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
            System.Threading.Thread.Sleep(1000);
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
            System.Threading.Thread.Sleep(1000);
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

            //performing click operation for home button
            login.home.Click();
            System.Threading.Thread.Sleep(3000);
            ScreenShot();
            try
            {
                log.Info("Home is clicked");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            //performing click operation for home button
            login.photo.Click();
            System.Threading.Thread.Sleep(3000);
            ScreenShot();
            try
            {
                log.Info("Photo icon clicked");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

            //performing click operation for home button
            login.addPhoto.Click();
            System.Threading.Thread.Sleep(3000);
            ScreenShot();
            
                
            try
            {
                log.Info("Add Photo icon clicked");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            System.Threading.Thread.Sleep(3000);
            //FileUpload
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open"); // Window name to select a file 
            autoIt.Send(@"C:\Users\HP\Desktop\Dog.jpg"); // file path 
            System.Threading.Thread.Sleep(3000);
            autoIt.Send("{Enter}");

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
   