/* Project = Automating Facebook using DDT and POM
 * Created by = V SHALINI
 * created on = 16/09/21
 */
using System;
using AutoItX3Lib;
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
            System.Threading.Thread.Sleep(1000);

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
            Assert.AreEqual(driver.Url, "https://www.facebook.com/?sk=welcome");
            try
            {
                log.Info("Logged in successfully");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }


        }
        public static void UploadingFile(IWebDriver driver)
        {
            DoActions.InputEmailAndPassword_into_LoginInputFields(driver);
            FileUpload.Fileupload file = new FileUpload.Fileupload(driver);
            //performing click operation for home button
            file.home.Click();
            System.Threading.Thread.Sleep(8000);

            //performing click operation for home button
            file.photo.Click();
            System.Threading.Thread.Sleep(8000);


            file.text.SendKeys("Hello");
            System.Threading.Thread.Sleep(8000);



            //performing click operation for home button
            file.addPhoto.Click();
            System.Threading.Thread.Sleep(8000);

            System.Threading.Thread.Sleep(3000);
            //FileUpload
            AutoItX3 autoIt = new AutoItX3();
            autoIt.WinActivate("Open"); // Window name to select a file 
            autoIt.Send(@"C:\Users\HP\Desktop\Parrot.jpg"); // file path 
            System.Threading.Thread.Sleep(3000);
            autoIt.Send("{Enter}");

            //Post Photo
            file.post.Click();
            System.Threading.Thread.Sleep(1000);
            try
            {
                log.Info("FileUploaded successfully");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }

        }
        
        public static void Logout()
        {
            DoActions.InputEmailAndPassword_into_LoginInputFields(driver);
            System.Threading.Thread.Sleep(3000);
            Pages.LogoutPage logout = new Pages.LogoutPage(driver);
            logout.arrowBtn.Click();
            System.Threading.Thread.Sleep(3000);
            logout.logoutBtn.Click();
            try
            {
                log.Info("Logged out successfully");
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
            }
            System.Threading.Thread.Sleep(3000);
            Assert.AreEqual(driver.Url, "");
        }


    }
}
   