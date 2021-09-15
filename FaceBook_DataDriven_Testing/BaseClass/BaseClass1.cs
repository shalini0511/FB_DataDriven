using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FaceBook_DataDriven_Testing.BaseClass
{
    public class BaseClass1
    {
        public static IWebDriver driver;
        [SetUp]
        public void SetUp()
        {
                
            //local selenium webdriver
            driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/";
            //To Maximize window
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(200);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
